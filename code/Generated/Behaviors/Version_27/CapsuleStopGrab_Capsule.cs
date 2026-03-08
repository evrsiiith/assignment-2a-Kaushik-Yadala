// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class CapsuleStopGrab_Capsule : MonoBehaviour
    {
        void Update()
        {
            if ((CapsuleStateStorage.Get(GameObject.Find("Capsule")) == CapsuleStateEnum.Grabbed && UserAlgorithms.IsMouseReleased(GameObject.Find("Capsule"))))
            {
                UserAlgorithms.StopGrab(GameObject.Find("Capsule"));
            }
        }
    }
}
