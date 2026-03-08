// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_25
{
    public class ToggleCubeToGreen_color_cube : MonoBehaviour
    {
        void Update()
        {
            if ((color_cubeStateStorage.Get(GameObject.Find("color_cube")) == color_cubeStateEnum.Red && UserAlgorithms.IsObjectClicked(GameObject.Find("color_cube"))))
            {
                UserAlgorithms.SetColorGreen(GameObject.Find("color_cube"));
            }
        }
    }
}
