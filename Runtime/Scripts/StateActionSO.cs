using System;
using UnityEngine;

namespace ModularStateMachine
{
    public abstract class StateActionSO : ScriptableObject
    {
        [SerializeField] private StateActionAnnotation annotations;
        public abstract void Execute(StateMachineController controller);
        // Example concrete: public class DebugLogAction : StateActionSO { [SerializeField] string message; public override void Execute(...) { Debug.Log(message); } }
    }

    [Serializable]
    public struct StateActionAnnotation
    {
        /// <summary>
        /// Readable name of the action, used to easily identify it in the editor.
        /// </summary>
        [Tooltip("Readable name of the action, used to easily identify it in the editor.")]
        public string readableName;

        /// <summary>
        /// Optional description of the action, used to easily identify it in the editor.
        /// </summary>
        [TextArea, Tooltip("Optional description, used to easily identify it in the editor.")] 
        public string description;
    }
}