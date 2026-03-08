// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_23
{
    public static class TableTopStateStorage
    {
        private static Dictionary<GameObject, TableTopStateEnum> stateTable = new();

        public static event Action<GameObject, TableTopStateEnum> OnStateChanged;

        public static void Register(GameObject obj, TableTopStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static TableTopStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == TableTopStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, TableTopStateEnum.Ready);

        private static void SetState(GameObject obj, TableTopStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
