using UnityEngine;

namespace ModularStateMachine
{

    [CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/Condition/Wait For Seconds")]
    public class Condition_WaitForSeconds : ConditionSO
    {
        [SerializeField] private float waitime = 1f;
        private float elapsedTime;
        public override bool Decide(StateMachineController controller)
        {
            if (elapsedTime > waitime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
