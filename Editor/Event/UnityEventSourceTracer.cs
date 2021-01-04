namespace Tilia.DeveloperTools.Event
{
    using System.Collections.Generic;
    using Tilia.DeveloperTools.Extension;
    using UnityEditor;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Utility;

    [InitializeOnLoad]
    public class UnityEventSourceTracer : EditorWindow
    {
        private const string windowTitle = "UnityEvent Source Tracer";
        private static EditorWindow promptWindow;
        private Vector2 scrollPosition;
        private Dictionary<Component, List<Component>> cache = new Dictionary<Component, List<Component>>();
        private List<string> selectedComponents = new List<string>();
        private List<Component> backingSelectedComponents = new List<Component>();
        private int selectedComponentIndex;
        private int lastSelectedIndex;
        private GameObject selectedGameObejct;
        private List<Component> foundCallers = new List<Component>();

        public void OnGUI()
        {
            using (GUILayout.ScrollViewScope scrollViewScope = new GUILayout.ScrollViewScope(scrollPosition))
            {
                scrollPosition = scrollViewScope.scrollPosition;
                GUILayout.Label("Trace UnityEvent Sources", EditorStyles.boldLabel);

                if (GUILayout.Button((cache.Count == 0 ? "B" : "Reb") + "uild Cache"))
                {
                    ClearSelectedComponents();
                    BuildCache();
                }

                EditorHelper.DrawHorizontalLine();

                if (cache.Count > 0)
                {
                    if (selectedComponents.Count > 0)
                    {
                        selectedComponentIndex = EditorGUILayout.Popup("Available Components", selectedComponentIndex, selectedComponents.ToArray());

                        if (!selectedComponentIndex.Equals(lastSelectedIndex))
                        {
                            foundCallers.Clear();
                        }

                        EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.PrefixLabel(" ");
                        if (GUILayout.Button("Find Source UnityEvents"))
                        {
                            foundCallers = GetAllCallingComponents(backingSelectedComponents[selectedComponentIndex]);
                        }
                        EditorGUILayout.EndHorizontal();

                        EditorHelper.DrawHorizontalLine();

                        if (foundCallers.Count > 0)
                        {
                            GUILayout.Label("Found Sources", EditorStyles.boldLabel);
                        }
                        else
                        {
                            EditorGUILayout.HelpBox("No Sources Found", MessageType.Info);
                        }

                        foreach (Component component in foundCallers)
                        {
                            if (GUILayout.Button(component.GetType().Name + " on " + component.name))
                            {
                                EditorGUIUtility.PingObject(component.gameObject);
                            }
                        }

                        lastSelectedIndex = selectedComponentIndex;
                    }
                    else
                    {
                        BuildSelectedComponents();
                    }
                }
            }

            if (selectedGameObejct == null || !selectedGameObejct.Equals(Selection.activeGameObject))
            {
                ClearSelectedComponents();
            }
            selectedGameObejct = Selection.activeGameObject;
        }

        private List<Component> GetAllCallingComponents(Component target)
        {
            List<Component> results = new List<Component>();
            if (cache.ContainsKey(target))
            {
                foreach (Component source in cache[target])
                {
                    results.Add(source);
                }
            }
            return results;
        }

        private void ClearSelectedComponents()
        {
            selectedComponents.Clear();
            backingSelectedComponents.Clear();
            foundCallers.Clear();
            selectedComponentIndex = 0;
        }

        private void BuildSelectedComponents()
        {
            ClearSelectedComponents();
            GameObject obj = Selection.activeGameObject;
            if (obj == null)
            {
                return;
            }

            List<Component> components = new List<Component>();
            obj.GetComponents(components);
            foreach (Component component in components)
            {
                backingSelectedComponents.Add(component);
                selectedComponents.Add(ObjectNames.NicifyVariableName(component.GetType().Name));
            }
        }

        private void BuildCache()
        {
            cache.Clear();
            foreach (GameObject obj in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
            {
                if (EditorUtility.IsPersistent(obj) || obj.hideFlags != HideFlags.None)
                {
                    continue;
                }

                GetComponentsFromGameObject(obj);
            }
        }

        private void GetComponentsFromGameObject(GameObject obj)
        {
            List<Component> components = new List<Component>();
            obj.GetComponents(components);
            foreach (Component component in components)
            {
                GetUnityEvent(component);
            }
        }

        private void GetUnityEvent(Component component)
        {
            SerializedProperty iterator = new SerializedObject(component).GetIterator();
            iterator.Next(true);
            GetUnityEvent(component, iterator, 0);
        }

        private bool GetUnityEvent(Component component, SerializedProperty iterator, int depth)
        {
            bool hasData;
            do
            {
                SerializedProperty persistentCalls = iterator.FindPropertyRelative("m_PersistentCalls.m_Calls");
                bool isUnityEvent = persistentCalls != null;
                if (isUnityEvent && persistentCalls.arraySize > 0)
                {
                    UnityEventBase unityEvent = iterator.GetTargetObjectOfProperty() as UnityEventBase;
                    GetUnityEventListeners(component, unityEvent, iterator.displayName, iterator.propertyPath);
                }
                hasData = iterator.Next(!isUnityEvent);
                if (hasData)
                {
                    if (iterator.depth < depth)
                    {
                        return hasData;
                    }
                    else if (iterator.depth > depth)
                    {
                        hasData = GetUnityEvent(component, iterator, iterator.depth);
                    }
                }
            }
            while (hasData);
            return false;
        }

        private void GetUnityEventListeners(Component caller, UnityEventBase unityEvent, string shortName, string fullName)
        {
            for (int i = 0; i < unityEvent.GetPersistentEventCount(); i++)
            {
                string methodName = unityEvent.GetPersistentMethodName(i);
                Object persistentTarget = unityEvent.GetPersistentTarget(i);
                Component receiver = null;
                try
                {
                    receiver = (Component)persistentTarget;
                }
                catch (System.Exception)
                {
                }

                if (receiver != null && methodName != null && methodName != "")
                {
                    if (!cache.ContainsKey(receiver))
                    {
                        cache.Add(receiver, new List<Component>());
                    }
                    cache[receiver].Add(caller);
                }
            }
        }

        [MenuItem("Window/Tilia/DeveloperTools/" + windowTitle)]
        private static void ShowWindow()
        {
            promptWindow = EditorWindow.GetWindow(typeof(UnityEventSourceTracer));
            promptWindow.titleContent = new GUIContent(windowTitle);
        }
    }
}