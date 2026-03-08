// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_26
{
    public static class CapsuleStateAPI
    {
        public static bool Free(GameObject obj) => CapsuleStateStorage.IsFree(obj);
        public static bool Grabbed(GameObject obj) => CapsuleStateStorage.IsGrabbed(obj);

        public static void SetFree(GameObject obj) => CapsuleStateStorage.SetFree(obj);
        public static void SetGrabbed(GameObject obj) => CapsuleStateStorage.SetGrabbed(obj);
    }
}
