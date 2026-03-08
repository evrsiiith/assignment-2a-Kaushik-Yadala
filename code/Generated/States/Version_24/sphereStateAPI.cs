// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_24
{
    public static class sphereStateAPI
    {
        public static bool Floating(GameObject obj) => sphereStateStorage.IsFloating(obj);
        public static bool Rolling(GameObject obj) => sphereStateStorage.IsRolling(obj);

        public static void SetFloating(GameObject obj) => sphereStateStorage.SetFloating(obj);
        public static void SetRolling(GameObject obj) => sphereStateStorage.SetRolling(obj);
    }
}
