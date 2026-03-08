// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_23
{
    public static class rampStateStorage
    {
        private static Dictionary<GameObject, rampStateEnum> stateTable = new();

        public static event Action<GameObject, rampStateEnum> OnStateChanged;

        public static void Register(GameObject obj, rampStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static rampStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == rampStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, rampStateEnum.Ready);

        private static void SetState(GameObject obj, rampStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
