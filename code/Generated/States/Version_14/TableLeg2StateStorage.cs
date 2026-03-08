// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_14
{
    public static class TableLeg2StateStorage
    {
        private static Dictionary<GameObject, TableLeg2StateEnum> stateTable = new();

        public static event Action<GameObject, TableLeg2StateEnum> OnStateChanged;

        public static void Register(GameObject obj, TableLeg2StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static TableLeg2StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == TableLeg2StateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, TableLeg2StateEnum.Ready);

        private static void SetState(GameObject obj, TableLeg2StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
