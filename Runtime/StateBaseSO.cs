using System.Collections.Generic;
using UnityEngine;

namespace ModularStateMachine
{
    public abstract class StateBaseSO : ScriptableObject
    {
        [SerializeField] protected List<StateActionSO> enterActions = new();
        [SerializeField] protected List<StateActionSO> updateActions = new();
        [SerializeField] protected List<StateActionSO> exitActions = new();
        [SerializeField] protected List<Transition> transitions = new();

        [Header("Hierarchy (Optional)")]
        [SerializeField] protected StateMachineSO subMachine; // If set, this is hierarchical

        public virtual void Enter(StateMachineController controller)
        {
            foreach (var action in enterActions) action.Execute(controller);

            if (subMachine != null && subMachine.initialState != null)
            {
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
                if (transition.condition.Decide(controller))
                {
                    return transition.targetState;
                }
            }
            return null;
        }
    }
}