using UnityEngine;

namespace ModularStateMachine
{
    [CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/State Machine")]
    public class StateMachineSO : ScriptableObject
    {
        public StateSO initialState;
        // Add shared data here, e.g., [SerializeField] FloatVariableSO health; (using RuntimeVariables pattern)
    }
}