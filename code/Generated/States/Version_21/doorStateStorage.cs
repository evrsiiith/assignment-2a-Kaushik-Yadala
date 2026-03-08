// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_21
{
    public static class doorStateStorage
    {
        private static Dictionary<GameObject, doorStateEnum> stateTable = new();

        public static event Action<GameObject, doorStateEnum> OnStateChanged;

        public static void Register(GameObject obj, doorStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static doorStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == doorStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, doorStateEnum.Ready);

        private static void SetState(GameObject obj, doorStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
