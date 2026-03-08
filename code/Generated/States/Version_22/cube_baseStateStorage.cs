// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_22
{
    public static class cube_baseStateStorage
    {
        private static Dictionary<GameObject, cube_baseStateEnum> stateTable = new();

        public static event Action<GameObject, cube_baseStateEnum> OnStateChanged;

        public static void Register(GameObject obj, cube_baseStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static cube_baseStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == cube_baseStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, cube_baseStateEnum.Ready);

        private static void SetState(GameObject obj, cube_baseStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
