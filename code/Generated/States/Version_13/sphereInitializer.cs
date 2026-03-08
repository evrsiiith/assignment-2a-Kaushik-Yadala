// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_13
{
    public class sphereInitializer : MonoBehaviour
    {
        public sphereStateEnum initialState = sphereStateEnum.Floating;

        void Awake()
        {
            sphereStateStorage.Register(gameObject, initialState);
        }
    }
}
