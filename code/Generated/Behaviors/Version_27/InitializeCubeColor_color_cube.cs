// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class InitializeCubeColor_color_cube : MonoBehaviour
    {
        void Update()
        {
            if (UserAlgorithms.NeedsInitialization(GameObject.Find("color_cube")))
            {
                UserAlgorithms.SetColorGreen(GameObject.Find("color_cube"));
            }
        }
    }
}
