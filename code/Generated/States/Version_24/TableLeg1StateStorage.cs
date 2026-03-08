// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_24
{
    public static class TableLeg1StateStorage
    {
        private static Dictionary<GameObject, TableLeg1StateEnum> stateTable = new();

        public static event Action<GameObject, TableLeg1StateEnum> OnStateChanged;

        public static void Register(GameObject obj, TableLeg1StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static TableLeg1StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == TableLeg1StateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, TableLeg1StateEnum.Ready);

        private static void SetState(GameObject obj, TableLeg1StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
