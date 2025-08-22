namespace ModularStateMachine
{
    [System.Serializable]
    public class Transition
    {
        public ConditionSO condition;
        public StateSO targetState;
    }
}