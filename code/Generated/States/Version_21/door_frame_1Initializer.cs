// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_21
{
    public class door_frame_1Initializer : MonoBehaviour
    {
        public door_frame_1StateEnum initialState = door_frame_1StateEnum.Ready;

        void Awake()
        {
            door_frame_1StateStorage.Register(gameObject, initialState);
        }
    }
}
