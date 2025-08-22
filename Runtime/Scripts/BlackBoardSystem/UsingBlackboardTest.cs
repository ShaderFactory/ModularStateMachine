using NUnit.Framework.Constraints;
using UnityEngine;

namespace ModularStateMachine
{
    public class UsingBlackboardTest : MonoBehaviour
    {
        [SerializeField] BlackboardData blackboardData;
        readonly Blackboard blackboard = new Blackboard();
        BlackboardKey isSafeKey;

        private void Awake()
        {
            blackboardData.SetValuesOnBlackboard(blackboard);
            isSafeKey = new BlackboardKey("IsSafe");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (blackboard.TryGetValue(isSafeKey, out bool isSafe))
                { 
                    blackboard.SetValue(isSafeKey, !isSafe);
                    Debug.Log($"IsSafe: {isSafe}");
                }
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                blackboard.SetValue(new BlackboardKey("MyBoolean"), true);

                if (blackboard.TryGetValue(new BlackboardKey("MyBoolean"), out bool isSafe))
                {
                    blackboard.SetValue(isSafeKey, !isSafe);
                    Debug.Log($"IsSafe: {isSafe}");

                }
            }
        }
    }
}
