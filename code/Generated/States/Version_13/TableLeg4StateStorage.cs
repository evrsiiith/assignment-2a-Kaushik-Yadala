// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_13
{
    public static class TableLeg4StateStorage
    {
        private static Dictionary<GameObject, TableLeg4StateEnum> stateTable = new();

        public static event Action<GameObject, TableLeg4StateEnum> OnStateChanged;

        public static void Register(GameObject obj, TableLeg4StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static TableLeg4StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == TableLeg4StateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, TableLeg4StateEnum.Ready);

        private static void SetState(GameObject obj, TableLeg4StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
