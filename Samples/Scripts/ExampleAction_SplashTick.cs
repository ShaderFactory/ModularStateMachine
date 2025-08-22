using UnityEngine;

namespace ModularStateMachine
{
    [CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/Action/Example Actions/Splash Tick")]
    public class ExampleAction_SplashTick : StateActionSO
    {
        private BlackboardKey key = new BlackboardKey("SplashTime");

        public override void Execute(StateMachineController controller)
        {
            float baseValue = 0f;
            if (controller.GetBlackboard().TryGetValue(key, out float value))
            {
                baseValue = value;
            }
            controller.GetBlackboard().SetValue(key, baseValue + Time.deltaTime);

            if(Input.GetKeyDown(KeyCode.Backspace))
            {
                controller.GetBlackboard().Debug();
            }
        }
    }
}