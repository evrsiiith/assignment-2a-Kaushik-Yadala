// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_15
{
    public static class cube_base_1StateStorage
    {
        private static Dictionary<GameObject, cube_base_1StateEnum> stateTable = new();

        public static event Action<GameObject, cube_base_1StateEnum> OnStateChanged;

        public static void Register(GameObject obj, cube_base_1StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static cube_base_1StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == cube_base_1StateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, cube_base_1StateEnum.Ready);

        private static void SetState(GameObject obj, cube_base_1StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
