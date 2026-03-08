// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_26
{
    public static class door_frame_2StateStorage
    {
        private static Dictionary<GameObject, door_frame_2StateEnum> stateTable = new();

        public static event Action<GameObject, door_frame_2StateEnum> OnStateChanged;

        public static void Register(GameObject obj, door_frame_2StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static door_frame_2StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == door_frame_2StateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, door_frame_2StateEnum.Ready);

        private static void SetState(GameObject obj, door_frame_2StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
