namespace Tilia.DeveloperTools.Event
{
    using System.Collections.Generic;
    using Tilia.DeveloperTools.Extension;
    using UnityEditor;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Utility;

    [InitializeOnLoad]
    public class UnityEventSourceTracer : EditorWindow, IHasCustomMenu
    {
        public List<GameObject> selectedHistory = new List<GameObject>();

        private const string windowPath = "Window/Tilia/DeveloperTools/";
        private const string windowTitle = "UnityEvent Source Tracer";
        private const string titleLabel = "Trace UnityEvent Sources";
        private const string cacheButtonEmptyText = "B";
        private const string cacheButtonNotEmptyText = "Reb";
        private const string cacheButtonText = "uild Cache";
        private const string noCacheText = "No data cache found, click the `Build Cache` button";
        private const string componentsPopupLabel = "Available Components";
        private const string findEventsButton = "Find Source UnityEvents";
        private const string eventSourcesLabel = "Event Sources";
        private const string noSourcesFoundText = "No Sources Found";
        private const string highlightButtonText = "Highlight";
        private const string highlightButtonTooltip = "Highlight Event Source GameObject";
        private const string highlightLabelSeperator = " on ";
        private const string selectionHistoryLabel = "Target History";
        private const string clearSelectionHistoryButton = "Clear List";
        private const string noHistoryFoundText = "No Target History Found";
        private const string gameObjectText = "GameObject";

        private static EditorWindow promptWindow;
        private Vector2 scrollPosition;
        private Dictionary<Object, List<Object>> cache = new Dictionary<Object, List<Object>>();
        private List<string> selectedComponents = new List<string>();
        private List<Object> backingSelectedComponents = new List<Object>();
        private int selectedComponentIndex;
        private int lastSelectedIndex;
        private GameObject selectedGameObejct;
        private List<Object> foundCallers = new List<Object>();
        private GUIContent highlightButtonContent = new GUIContent(highlightButtonText, highlightButtonTooltip);

        [System.NonSerialized]
        private GUIStyle lockButtonStyle;
        [System.NonSerialized]
        private bool locked = false;

        public void OnGUI()
        {
            using (GUILayout.ScrollViewScope scrollViewScope = new GUILayout.ScrollViewScope(scrollPosition))
            {
                scrollPosition = scrollViewScope.scrollPosition;

                DisplayTitle();
                EditorHelper.DrawHorizontalLine();

                if (cache.Count > 0)
                {
                    if (selectedComponents.Count > 0)
                    {
                        DisplayAvailableComponents();
                        EditorHelper.DrawHorizontalLine();
                        DisplayEventSources();
                        EditorHelper.DrawHorizontalLine();
                        DisplaySelectionHistory();
                    }
                    else
                    {
                        BuildSelectedComponents();
                    }
                }
                else
                {
                    EditorGUILayout.HelpBox(noCacheText, MessageType.Info);
                }
            }

            CheckSelectedComponentState();
        }

        private void DisplayTitle()
        {
            EditorGUILayout.Space();
            EditorGUILayout.BeginHorizontal();

            GUILayout.Label(titleLabel, EditorStyles.boldLabel);

            if (!locked)
            {
                GUILayout.FlexibleSpace();
                if (GUILayout.Button(GenerateBuildCacheButtonText()))
                {
                    selectedHistory.Clear();
                    ClearSelectedComponents();
                    BuildCache();
                }
            }

            EditorGUILayout.EndHorizontal();
        }

        private string GenerateBuildCacheButtonText()
        {
            return (cache.Count == 0 ? cacheButtonEmptyText : cacheButtonNotEmptyText) + cacheButtonText;
        }

        private void DisplayAvailableComponents()
        {
            selectedComponentIndex = EditorGUILayout.Popup(componentsPopupLabel, selectedComponentIndex, selectedComponents.ToArray());

            if (!selectedComponentIndex.Equals(lastSelectedIndex))
            {
                foundCallers.Clear();
            }

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel(" ");
            if (GUILayout.Button(findEventsButton))
            {
                foundCallers = GetAllCallingComponents(backingSelectedComponents[selectedComponentIndex]);
            }
            EditorGUILayout.EndHorizontal();

            lastSelectedIndex = selectedComponentIndex;
        }

        private void DisplayEventSources()
        {
            GUILayout.Label(eventSourcesLabel, EditorStyles.boldLabel);
            if (foundCallers.Count == 0)
            {
                EditorGUILayout.HelpBox(noSourcesFoundText, MessageType.Info);
            }
            else
            {
                GUILayout.BeginVertical("", "box");
                foreach (Component component in foundCallers)
                {
                    GUILayout.BeginHorizontal();
                    GUILayout.Label(component.GetType().Name + highlightLabelSeperator + component.name, new GUIStyle() { wordWrap = true });
                    GUILayout.FlexibleSpace();
                    if (GUILayout.Button(highlightButtonContent))
                    {
                        if (!IsCurrentSelectionLatestHistoryItem())
                        {
                            selectedHistory.Add(selectedGameObejct);
                        }
                        EditorGUIUtility.PingObject(component.gameObject);
                    }
                    GUILayout.EndHorizontal();
                    EditorHelper.DrawHorizontalLine();
                }
                GUILayout.EndVertical();
            }
        }

        private bool IsCurrentSelectionLatestHistoryItem()
        {
            return selectedHistory.Count - 1 >= 0 && selectedHistory[selectedHistory.Count - 1] == selectedGameObejct;
        }

        private void DisplaySelectionHistory()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(selectionHistoryLabel, EditorStyles.boldLabel);
            if (selectedHistory.Count > 0)
            {
                GUILayout.FlexibleSpace();
                if (GUILayout.Button(clearSelectionHistoryButton))
                {
                    selectedHistory.Clear();
                }
            }
            GUILayout.EndHorizontal();

            if (selectedHistory.Count > 0)
            {
                EditorGUILayout.Space();
                EditorGUI.BeginDisabledGroup(true);
                foreach (GameObject historyObject in selectedHistory)
                {
                    EditorGUILayout.ObjectField(historyObject, historyObject.GetType(), true);
                }
                EditorGUI.EndDisabledGroup();
                EditorGUILayout.Space();
            }
            else
            {
                EditorGUILayout.HelpBox(noHistoryFoundText, MessageType.Info);
            }
        }

        private void CheckSelectedComponentState()
        {
            if (!locked)
            {
                if (selectedGameObejct == null || !selectedGameObejct.Equals(Selection.activeGameObject))
                {
                    ClearSelectedComponents();
                }
                selectedGameObejct = Selection.activeGameObject;
            }
        }

        private List<Object> GetAllCallingComponents(Object target)
        {
            List<Object> results = new List<Object>();
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

            backingSelectedComponents.Add(obj);
            selectedComponents.Add(ObjectNames.NicifyVariableName(gameObjectText + " (" + obj.name + ")"));
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

                if (persistentTarget != null && methodName != null && methodName != "")
                {
                    if (!cache.ContainsKey(persistentTarget))
                    {
                        cache.Add(persistentTarget, new List<Object>());
                    }
                    cache[persistentTarget].Add(caller);
                }
            }
        }

        private void ShowButton(Rect position)
        {
            if (lockButtonStyle == null)
            {
                lockButtonStyle = "IN LockButton";
            }
            locked = GUI.Toggle(position, locked, GUIContent.none, lockButtonStyle);
        }

        [MenuItem(windowPath + windowTitle)]
        private static void ShowWindow()
        {
            promptWindow = GetWindow(typeof(UnityEventSourceTracer));
            promptWindow.titleContent = new GUIContent(windowTitle);
        }

        void IHasCustomMenu.AddItemsToMenu(GenericMenu menu)
        {
            menu.AddItem(new GUIContent("Lock"), locked, () =>
            {
                locked = !locked;
            });
        }
    }
}