// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_26
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

        public static bool IsClosed(GameObject obj) => stateTable[obj] == doorStateEnum.Closed;
        public static bool IsOpen(GameObject obj) => stateTable[obj] == doorStateEnum.Open;

        public static void SetClosed(GameObject obj) => SetState(obj, doorStateEnum.Closed);
        public static void SetOpen(GameObject obj) => SetState(obj, doorStateEnum.Open);

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
