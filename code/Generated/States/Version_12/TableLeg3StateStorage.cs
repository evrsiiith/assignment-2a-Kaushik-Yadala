// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_12
{
    public static class TableLeg3StateStorage
    {
        private static Dictionary<GameObject, TableLeg3StateEnum> stateTable = new();

        public static event Action<GameObject, TableLeg3StateEnum> OnStateChanged;

        public static void Register(GameObject obj, TableLeg3StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static TableLeg3StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == TableLeg3StateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, TableLeg3StateEnum.Ready);

        private static void SetState(GameObject obj, TableLeg3StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
