using ModularStateMachine;
using UnityEngine;

[CreateAssetMenu(menuName = "MyStateMachine/Decision/KeyPress")]
public class KeyPress : DecisionSO
{
    [SerializeField] private KeyCode key = KeyCode.Space; // Default to Space key
    public override bool Decide(StateMachineController controller)
    {
        return Input.GetKeyDown(key);
    }
}
