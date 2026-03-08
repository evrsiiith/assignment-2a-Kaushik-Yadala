// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_21
{
    public static class door_hingeStateStorage
    {
        private static Dictionary<GameObject, door_hingeStateEnum> stateTable = new();

        public static event Action<GameObject, door_hingeStateEnum> OnStateChanged;

        public static void Register(GameObject obj, door_hingeStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static door_hingeStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsClosed(GameObject obj) => stateTable[obj] == door_hingeStateEnum.Closed;
        public static bool IsOpen(GameObject obj) => stateTable[obj] == door_hingeStateEnum.Open;

        public static void SetClosed(GameObject obj) => SetState(obj, door_hingeStateEnum.Closed);
        public static void SetOpen(GameObject obj) => SetState(obj, door_hingeStateEnum.Open);

        private static void SetState(GameObject obj, door_hingeStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
