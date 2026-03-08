// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_24
{
    public static class color_cubeStateStorage
    {
        private static Dictionary<GameObject, color_cubeStateEnum> stateTable = new();

        public static event Action<GameObject, color_cubeStateEnum> OnStateChanged;

        public static void Register(GameObject obj, color_cubeStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static color_cubeStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsGreen(GameObject obj) => stateTable[obj] == color_cubeStateEnum.Green;
        public static bool IsRed(GameObject obj) => stateTable[obj] == color_cubeStateEnum.Red;

        public static void SetGreen(GameObject obj) => SetState(obj, color_cubeStateEnum.Green);
        public static void SetRed(GameObject obj) => SetState(obj, color_cubeStateEnum.Red);

        private static void SetState(GameObject obj, color_cubeStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
