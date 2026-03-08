// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_15
{
    public static class sphereStateStorage
    {
        private static Dictionary<GameObject, sphereStateEnum> stateTable = new();

        public static event Action<GameObject, sphereStateEnum> OnStateChanged;

        public static void Register(GameObject obj, sphereStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static sphereStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsFloating(GameObject obj) => stateTable[obj] == sphereStateEnum.Floating;
        public static bool IsRolling(GameObject obj) => stateTable[obj] == sphereStateEnum.Rolling;

        public static void SetFloating(GameObject obj) => SetState(obj, sphereStateEnum.Floating);
        public static void SetRolling(GameObject obj) => SetState(obj, sphereStateEnum.Rolling);

        private static void SetState(GameObject obj, sphereStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
