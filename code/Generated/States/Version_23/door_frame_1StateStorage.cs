// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_23
{
    public static class door_frame_1StateStorage
    {
        private static Dictionary<GameObject, door_frame_1StateEnum> stateTable = new();

        public static event Action<GameObject, door_frame_1StateEnum> OnStateChanged;

        public static void Register(GameObject obj, door_frame_1StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static door_frame_1StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == door_frame_1StateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, door_frame_1StateEnum.Ready);

        private static void SetState(GameObject obj, door_frame_1StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
