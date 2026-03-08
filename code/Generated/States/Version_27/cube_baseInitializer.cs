// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class cube_baseInitializer : MonoBehaviour
    {
        public cube_baseStateEnum initialState = cube_baseStateEnum.Ready;

        void Awake()
        {
            cube_baseStateStorage.Register(gameObject, initialState);
        }
    }
}
