// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_26
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
