using NUnit.Framework.Constraints;
using UnityEngine;

namespace ModularStateMachine
{
    [CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/Action/Example Actions/Log State Name")]
    public class Action_LogStateName : StateActionSO
    {
        private BlackboardKey key;
        [SerializeField] private string prefix, suffix;

        public override void Execute(StateMachineController controller)
        {
            // Register an amount of times that this action type has been executed.
            key = new BlackboardKey("Action_LogStateName_Count");

            if (controller.GetBlackboard().TryGetValue(key, out int result))
            {
                controller.GetBlackboard().SetValue(key, result++);
            }
            else
            {
                controller.GetBlackboard().SetValue(key, 1);
            }

                Debug.Log($"{prefix} {controller.GetCurrentState().name} {suffix}");
        }
    }
}