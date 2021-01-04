namespace Tilia.DeveloperTools.Extension
{
    using System;
    using System.Collections;
    using System.Reflection;

    /// <summary>
    /// Extended methods for the <see cref="object"/> Type.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Gets the value for the given property name.
        /// </summary>
        /// <param name="source">The <see cref="object"/> to retrieve from.</param>
        /// <param name="name">The name of the property to retrieve.</param>
        /// <returns>The found value.</returns>
        public static object GetValue(this object source, string name)
        {
            if (source == null)
            {
                return null;
            }

            Type type = source.GetType();

            while (type != null)
            {
                FieldInfo fieldInfo = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    return fieldInfo.GetValue(source);
                }

                PropertyInfo propertyInfo = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (propertyInfo != null)
                {
                    return propertyInfo.GetValue(source, null);
                }

                type = type.BaseType;
            }

            return null;
        }

        /// <summary>
        /// Gets the value for the given property name.
        /// </summary>
        /// <param name="source">The <see cref="object"/> to retrieve from.</param>
        /// <param name="name">The name of the property to retrieve.</param>
        /// <param name="index">The index to retrieve the property from.</param>
        /// <returns>The found value.</returns>
        public static object GetValue(this object source, string name, int index)
        {
            IEnumerable enumerable = source.GetValue(name) as IEnumerable;
            if (enumerable == null)
            {
                return null;
            }

            IEnumerator enumerator = enumerable.GetEnumerator();

            for (int enumeratorIndex = 0; enumeratorIndex <= index; enumeratorIndex++)
            {
                if (!enumerator.MoveNext())
                {
                    return null;
                }
            }
            return enumerator.Current;
        }
    }
}