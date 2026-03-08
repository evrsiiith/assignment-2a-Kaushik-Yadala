// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_21
{
    public class door_hingeInitializer : MonoBehaviour
    {
        public door_hingeStateEnum initialState = door_hingeStateEnum.Closed;

        void Awake()
        {
            door_hingeStateStorage.Register(gameObject, initialState);
        }
    }
}
