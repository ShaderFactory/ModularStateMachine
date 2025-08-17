using System.Collections.Generic;
using UnityEngine;

namespace ModularStateMachine
{
    public class StateMachineController : MonoBehaviour
    {
        [SerializeField] private StateMachineDataSO rootMachine;

        private StateSO currentState;
        private Stack<StateSO> stateStack = new Stack<StateSO>(); // For hierarchy depth

        void Start()
        {
            if (rootMachine != null && rootMachine.initialState != null)
            {
                ChangeState(rootMachine.initialState);
            }
        }

        void Update()
        {
            if (currentState != null)
            {
                currentState.Tick(this);
                var nextState = currentState.CheckTransitions(this);
                if (nextState != null)
                {
                    ChangeState(nextState);
                }
            }
        }

        public void ChangeState(StateSO newState)
        {
            if (currentState != null) currentState.Exit(this);
            currentState = newState;
            currentState.Enter(this);
        }

        // Hierarchy Helpers
        public void PushSubState(StateSO subState)
        {
            stateStack.Push(currentState);
            ChangeState(subState); // Now current is the sub-state
        }

        public void PopSubState()
        {
            if (stateStack.Count > 0)
            {
                ChangeState(stateStack.Pop()); // Return to parent
            }
        }

        // Expose data for actions/decisions, e.g., public Rigidbody rb; public Transform target;
    }
}