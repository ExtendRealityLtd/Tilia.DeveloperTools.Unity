namespace Tilia.DeveloperTools.Output
{
    using UnityEngine;

    /// <summary>
    /// Basic methods for logging common data types to the Unity console window.
    /// </summary>
    public class ConsoleLogger : MonoBehaviour
    {
        /// <summary>
        /// Logs an <see cref="bool"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogBoolean(bool value)
        {
            Debug.Log(value);
        }

        /// <summary>
        /// Logs an <see cref="int"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogInteger(int value)
        {
            Debug.Log(value);
        }

        /// <summary>
        /// Logs an <see cref="float"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogFloat(float value)
        {
            Debug.Log(value);
        }

        /// <summary>
        /// Logs an <see cref="double"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogDouble(double value)
        {
            Debug.Log(value);
        }

        /// <summary>
        /// Logs an <see cref="decimal"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogDecimal(decimal value)
        {
            Debug.Log(value);
        }

        /// <summary>
        /// Logs an <see cref="char"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogChar(char value)
        {
            Debug.Log(value);
        }

        /// <summary>
        /// Logs an <see cref="string"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogString(string value)
        {
            Debug.Log(value);
        }

        /// <summary>
        /// Logs an <see cref="Vector2"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogVector2(Vector2 value)
        {
            Debug.Log(value.x + ", " + value.y);
        }

        /// <summary>
        /// Logs an <see cref="Vector3"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogVector3(Vector3 value)
        {
            Debug.Log(value.x + ", " + value.y + ", " + value.z);
        }

        /// <summary>
        /// Logs an <see cref="Transform"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogTransform(Transform value)
        {
            LogGameObject(value != null ? value.gameObject : null);
        }

        /// <summary>
        /// Logs an <see cref="GameObject"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogGameObject(GameObject value)
        {
            Debug.Log(value, value != null ? value : null);
        }

        /// <summary>
        /// Logs an <see cref="object"/> to the Unity console window.
        /// </summary>
        /// <param name="value">The value to log out.</param>
        public virtual void LogObject(object value)
        {
            Debug.Log(value != null ? value.ToString() : null);
        }
    }
}