using System.Collections.Generic;
using UnityEngine;

namespace ModularStateMachine
{
    public abstract class StateSO : ScriptableObject
    {
        [SerializeField] protected List<StateActionSO> enterActions = new List<StateActionSO>();
        [SerializeField] protected List<StateActionSO> updateActions = new List<StateActionSO>();
        [SerializeField] protected List<StateActionSO> exitActions = new List<StateActionSO>();
        [SerializeField] protected List<Transition> transitions = new List<Transition>();

        [Header("Hierarchy (Optional)")]
        [SerializeField] protected StateMachineDataSO subMachine; // If set, this is hierarchical

        public virtual void Enter(StateMachineController controller)
        {
            foreach (var action in enterActions) action.Execute(controller);
            if (subMachine != null)
            {
                // For hierarchy: Push sub-initial state to stack (handled in controller)
                controller.PushSubState(subMachine.initialState);
            }
        }

        public virtual void Tick(StateMachineController controller)
        {
            foreach (var action in updateActions) action.Execute(controller);
            // If hierarchical, tick is delegated via controller stack
        }

        public virtual void Exit(StateMachineController controller)
        {
            foreach (var action in exitActions) action.Execute(controller);
            if (subMachine != null)
            {
                controller.PopSubState();
            }
        }

        public virtual StateSO CheckTransitions(StateMachineController controller)
        {
            foreach (var transition in transitions)
            {
                if (transition.decision.Decide(controller))
                {
                    return transition.targetState;
                }
            }
            return null;
        }
    }
}