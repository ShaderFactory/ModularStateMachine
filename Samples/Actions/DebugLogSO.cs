using ModularStateMachine;
using UnityEngine;


[CreateAssetMenu(menuName = "MyStateMachine/Action/DebugLog")]
public class DebugLogActionSO : StateActionSO
{
    [SerializeField] private string message = "Entered Initial State";
    public override void Execute(StateMachineController controller)
    {
        Debug.Log(message);
    }
}