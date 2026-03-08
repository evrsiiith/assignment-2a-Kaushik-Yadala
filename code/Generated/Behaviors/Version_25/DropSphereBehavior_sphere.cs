// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_25
{
    public class DropSphereBehavior_sphere : MonoBehaviour
    {
        void Update()
        {
            if ((sphereStateStorage.Get(GameObject.Find("sphere")) == sphereStateEnum.Floating && UserAlgorithms.IsObjectClicked(GameObject.Find("sphere"))))
            {
                UserAlgorithms.DropSphere(GameObject.Find("sphere"));
            }
        }
    }
}
