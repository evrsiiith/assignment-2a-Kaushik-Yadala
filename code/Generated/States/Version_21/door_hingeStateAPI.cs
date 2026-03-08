// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_21
{
    public static class door_hingeStateAPI
    {
        public static bool Closed(GameObject obj) => door_hingeStateStorage.IsClosed(obj);
        public static bool Open(GameObject obj) => door_hingeStateStorage.IsOpen(obj);

        public static void SetClosed(GameObject obj) => door_hingeStateStorage.SetClosed(obj);
        public static void SetOpen(GameObject obj) => door_hingeStateStorage.SetOpen(obj);
    }
}
