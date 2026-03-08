// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class CapsuleStartGrab_Capsule : MonoBehaviour
    {
        void Update()
        {
            if ((CapsuleStateStorage.Get(GameObject.Find("Capsule")) == CapsuleStateEnum.Free && UserAlgorithms.IsObjectClicked(GameObject.Find("Capsule"))))
            {
                UserAlgorithms.StartGrab(GameObject.Find("Capsule"));
            }
        }
    }
}
