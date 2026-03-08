// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_18
{
    public class door_frame_2Initializer : MonoBehaviour
    {
        public door_frame_2StateEnum initialState = door_frame_2StateEnum.Ready;

        void Awake()
        {
            door_frame_2StateStorage.Register(gameObject, initialState);
        }
    }
}
