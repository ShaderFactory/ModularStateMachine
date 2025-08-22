using ModularStateMachine;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/State")]
public class StateSO : ScriptableObject
{
    [SerializeField] private List<StateActionSO> enterActions = new();
    [SerializeField] private List<StateActionSO> updateActions = new();
    [SerializeField] private List<StateActionSO> exitActions = new();
    [SerializeField] private List<Transition> transitions = new();

    [Header("Hierarchy (Optional)")]
    [SerializeField] private StateMachineSO subMachine; // <-- still supports nesting

    public void Enter(StateMachineController controller)
    {
        foreach (var action in enterActions) action.Execute(controller);

        if (subMachine != null && subMachine.initialState != null)
        {
            controller.PushSubState(subMachine.initialState);
        }
    }

    public void Tick(StateMachineController controller)
    {
        foreach (var action in updateActions) action.Execute(controller);
    }

    public void Exit(StateMachineController controller)
    {
        foreach (var action in exitActions) action.Execute(controller);
        if (subMachine != null)
            controller.PopSubState();
    }

    public StateSO CheckTransitions(StateMachineController controller)
    {
        foreach (var transition in transitions)
        {
            if (transition.condition.Decide(controller))
                return transition.targetState;
        }
        return null;
    }
}