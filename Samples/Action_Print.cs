using ModularStateMachine;
using UnityEngine;


[CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/Action/Print")]
public class DebugLogActionSO : StateActionSO
{
    [SerializeField] private string message = "Enter Message Here.";
    public enum PrintType {Regular, Warning, Error}
    [SerializeField] private PrintType printType = PrintType.Regular;

    public override void Execute(StateMachineController controller)
    {
        switch (printType)
        {
            case PrintType.Regular:
                Debug.Log(message);
                break;
            case PrintType.Warning:
                Debug.LogWarning(message);
                break;
            case PrintType.Error:
                Debug.LogError(message);
                break;
        }
    }
}