using UnityEngine;

namespace ModularStateMachine {
    public static class UnityObjectExtensions
    {
        /// <summary>
        /// Converts a UnityEngine.Object reference into a real null if it was destroyed.
        /// This avoids Unity's "fake null" problem.
        /// </summary>
        public static T OrNull<T>(this T obj) where T : Object
        {
            return obj == null ? null : obj;
        }
    }
}
