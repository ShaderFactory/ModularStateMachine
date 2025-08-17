namespace ModularStateMachine
{

    [System.Serializable]
    public class Transition
    {
        public DecisionSO decision;
        public StateSO targetState;
    }
}