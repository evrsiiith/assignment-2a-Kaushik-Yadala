// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_20
{
    public static class doorStateAPI
    {
        public static bool Closed(GameObject obj) => doorStateStorage.IsClosed(obj);
        public static bool Open(GameObject obj) => doorStateStorage.IsOpen(obj);

        public static void SetClosed(GameObject obj) => doorStateStorage.SetClosed(obj);
        public static void SetOpen(GameObject obj) => doorStateStorage.SetOpen(obj);
    }
}
