using UnityEngine;

namespace ModularStateMachine
{
    [CreateAssetMenu(menuName = "Shader Factory/Modular State Machine/Condition/Comparison")]
    public class FloatComparison : ConditionSO
    {
        // [SerializeField] private BlackboardEntryData key1; Commenting this out because at the moment there is no support for writing keys in the editor (Only lists of key).
        [SerializeField] private string blackboardKey;
        [SerializeField] private ComparisonType operation;
        [SerializeField] private float value2;
        private BlackboardKey storedKey;

        public override bool Decide(StateMachineController controller)
        {
            float value1 = 0f;
            storedKey = new BlackboardKey(blackboardKey); // Convert the string field to a BlackboardKey struct.

            if (!controller.GetBlackboard().TryGetValue(storedKey, out float resultKey))
            {
                controller.GetBlackboard().SetValue<float>(storedKey, 0f); // If key does not exist in blackboard, create it.
            }
            else
            {
                value1 = resultKey; // If key exists, get its value and assign to value1 so we can compare it.
            }


                switch (operation) // Comparing value 1.
                {
                    case ComparisonType.Equal:
                        return value1 == value2;
                    case ComparisonType.NotEqual:
                        return value1 != value2;
                    case ComparisonType.GreaterThan:
                        return value1 > value2;
                    case ComparisonType.LessThan:
                        return value1 < value2;
                    case ComparisonType.GreaterThanOrEqual:
                        return value1 >= value2;
                    case ComparisonType.LessThanOrEqual:
                        return value1 <= value2;
                    default:
                        return false;
                }
        }
    }
    public enum ComparisonType
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual
    }
}