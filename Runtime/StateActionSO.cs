using UnityEngine;

namespace ModularStateMachine
{
    public abstract class StateActionSO : ScriptableObject
    {
        public string stateActionName;
        public abstract void Execute(StateMachineController controller);
        // Example concrete: public class DebugLogAction : StateActionSO { [SerializeField] string message; public override void Execute(...) { Debug.Log(message); } }
    }
}