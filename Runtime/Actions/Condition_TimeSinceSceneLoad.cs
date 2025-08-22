using UnityEngine;

namespace ModularStateMachine
{
    [CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/Condition/Time Since Scene Load")]   
    public class Action_TimeSinceSceneLoad : ConditionSO
    {
        [Tooltip("After how many seconds after the scene is loaded do you want the condition to become true?")]
        [SerializeField] private float time;
        public override bool Decide(StateMachineController controller)
        {
            if(Time.timeSinceLevelLoad > 5f)
            {
                return true;
            }
            return false;
        }
    }
}
