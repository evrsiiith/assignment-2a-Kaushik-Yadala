// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class SlideDoorOpenBehavior_door : MonoBehaviour
    {
        void Update()
        {
            if ((doorStateStorage.Get(GameObject.Find("door")) == doorStateEnum.Closed && color_cubeStateStorage.Get(GameObject.Find("color_cube")) == color_cubeStateEnum.Green && UserAlgorithms.IsObjectClicked(GameObject.Find("door"))))
            {
                UserAlgorithms.SlideDoorOpen(GameObject.Find("door"));
            }
        }
    }
}
