// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_26
{
    public class Door_FrameInitializer : MonoBehaviour
    {
        public Door_FrameStateEnum initialState = Door_FrameStateEnum.Ready;

        void Awake()
        {
            Door_FrameStateStorage.Register(gameObject, initialState);
        }
    }
}
