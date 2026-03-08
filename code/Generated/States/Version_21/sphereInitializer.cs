// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_21
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
