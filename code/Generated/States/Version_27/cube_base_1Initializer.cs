// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class cube_base_1Initializer : MonoBehaviour
    {
        public cube_base_1StateEnum initialState = cube_base_1StateEnum.Ready;

        void Awake()
        {
            cube_base_1StateStorage.Register(gameObject, initialState);
        }
    }
}
