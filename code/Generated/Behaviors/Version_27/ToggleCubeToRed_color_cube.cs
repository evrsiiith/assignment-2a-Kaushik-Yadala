// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class ToggleCubeToRed_color_cube : MonoBehaviour
    {
        void Update()
        {
            if ((color_cubeStateStorage.Get(GameObject.Find("color_cube")) == color_cubeStateEnum.Green && UserAlgorithms.IsObjectClicked(GameObject.Find("color_cube"))))
            {
                UserAlgorithms.SetColorRed(GameObject.Find("color_cube"));
            }
        }
    }
}
