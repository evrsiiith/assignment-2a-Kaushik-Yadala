// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_22
{
    public static class CapsuleStateStorage
    {
        private static Dictionary<GameObject, CapsuleStateEnum> stateTable = new();

        public static event Action<GameObject, CapsuleStateEnum> OnStateChanged;

        public static void Register(GameObject obj, CapsuleStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static CapsuleStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsFree(GameObject obj) => stateTable[obj] == CapsuleStateEnum.Free;
        public static bool IsGrabbed(GameObject obj) => stateTable[obj] == CapsuleStateEnum.Grabbed;

        public static void SetFree(GameObject obj) => SetState(obj, CapsuleStateEnum.Free);
        public static void SetGrabbed(GameObject obj) => SetState(obj, CapsuleStateEnum.Grabbed);

        private static void SetState(GameObject obj, CapsuleStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
