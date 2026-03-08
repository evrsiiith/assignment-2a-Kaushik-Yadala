// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_21
{
    public class door_frame_3Initializer : MonoBehaviour
    {
        public door_frame_3StateEnum initialState = door_frame_3StateEnum.Ready;

        void Awake()
        {
            door_frame_3StateStorage.Register(gameObject, initialState);
        }
    }
}
