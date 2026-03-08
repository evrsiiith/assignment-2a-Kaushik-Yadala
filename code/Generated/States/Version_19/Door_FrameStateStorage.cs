// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_19
{
    public static class Door_FrameStateStorage
    {
        private static Dictionary<GameObject, Door_FrameStateEnum> stateTable = new();

        public static event Action<GameObject, Door_FrameStateEnum> OnStateChanged;

        public static void Register(GameObject obj, Door_FrameStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Door_FrameStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == Door_FrameStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, Door_FrameStateEnum.Ready);

        private static void SetState(GameObject obj, Door_FrameStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
