using UnityEngine;

namespace ModularStateMachine
{
    public abstract class ConditionSO : ScriptableObject
    {
        public abstract bool Decide(StateMachineController controller);
        // Example: public class KeyPressedDecision : DecisionSO { [SerializeField] KeyCode key; public override bool Decide(...) { return Input.GetKeyDown(key); } }
    }
}