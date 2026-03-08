// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_18
{
    public class color_cubeInitializer : MonoBehaviour
    {
        public color_cubeStateEnum initialState = color_cubeStateEnum.Green;

        void Awake()
        {
            color_cubeStateStorage.Register(gameObject, initialState);
        }
    }
}
