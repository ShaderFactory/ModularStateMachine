using UnityEngine;

namespace ModularStateMachine
{
    [CreateAssetMenu(menuName = "MyStateMachine/StateMachineData")]
    public class StateMachineDataSO : ScriptableObject
    {
        public StateSO initialState;
        // Add shared data here, e.g., [SerializeField] FloatVariableSO health; (using RuntimeVariables pattern)
    }
}