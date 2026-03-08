// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_26
{
    public class SlideDoorClosedBehavior_door : MonoBehaviour
    {
        void Update()
        {
            if ((doorStateStorage.Get(GameObject.Find("door")) == doorStateEnum.Open && color_cubeStateStorage.Get(GameObject.Find("color_cube")) == color_cubeStateEnum.Green && UserAlgorithms.IsObjectClicked(GameObject.Find("door"))))
            {
                UserAlgorithms.SlideDoorClosed(GameObject.Find("door"));
            }
        }
    }
}
