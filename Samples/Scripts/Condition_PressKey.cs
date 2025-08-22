using ModularStateMachine;
using UnityEngine;

namespace ModularStateMachine
{
    [CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/Condition/Key Press")]
    public class Condition_PressKey : ConditionSO
    {
        [SerializeField] KeyCode keycode = KeyCode.Space;
        public override bool Decide(StateMachineController controller)
        {
            return Input.GetKeyDown(keycode);
        }
    }
}