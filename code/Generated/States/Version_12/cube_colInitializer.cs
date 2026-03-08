// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_12
{
    public class cube_colInitializer : MonoBehaviour
    {
        public cube_colStateEnum initialState = cube_colStateEnum.Ready;

        void Awake()
        {
            cube_colStateStorage.Register(gameObject, initialState);
        }
    }
}
