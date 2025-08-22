using System;

namespace ModularStateMachine
{
    /// <summary>
    /// This event system issues global events for all active StateMachineController instances.
    /// </summary>
    public static class ModularStateMachineEvents
    {
        public static event Action<bool> OnGlobalPause;

        public static void TriggerGlobalPause(bool isPaused)
        {
            OnGlobalPause?.Invoke(isPaused);
        }
    }
}
