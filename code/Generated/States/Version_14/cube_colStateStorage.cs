// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_14
{
    public static class cube_colStateStorage
    {
        private static Dictionary<GameObject, cube_colStateEnum> stateTable = new();

        public static event Action<GameObject, cube_colStateEnum> OnStateChanged;

        public static void Register(GameObject obj, cube_colStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static cube_colStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == cube_colStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, cube_colStateEnum.Ready);

        private static void SetState(GameObject obj, cube_colStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
