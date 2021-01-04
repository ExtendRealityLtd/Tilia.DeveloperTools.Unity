namespace Tilia.DeveloperTools.Extension
{
    using UnityEditor;

    /// <summary>
    /// Extended methods for the <see cref="SerializedProperty"/> Type.
    /// </summary>
    public static class SerializedPropertyExtensions
    {
        /// <summary>
        /// Gets the target object of the given property.
        /// </summary>
        /// <param name="property">The <see cref="SerializedProperty"/> to retrieve from.</param>
        /// <returns>The target object.</returns>
        public static object GetTargetObjectOfProperty(this SerializedProperty property)
        {
            string path = property.propertyPath.Replace(".Array.data[", "[");
            object obj = property.serializedObject.targetObject;
            string[] elements = path.Split('.');
            foreach (string element in elements)
            {
                if (element.Contains("["))
                {
                    string elementName = element.Substring(0, element.IndexOf("["));
                    int index = System.Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
                    obj = obj.GetValue(elementName, index);
                }
                else
                {
                    obj = obj.GetValue(element);
                }
            }
            return obj;
        }
    }
}