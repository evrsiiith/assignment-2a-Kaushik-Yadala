// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class CapsuleDragging_Capsule : MonoBehaviour
    {
        void Update()
        {
            if ((CapsuleStateStorage.Get(GameObject.Find("Capsule")) == CapsuleStateEnum.Grabbed && UserAlgorithms.IsMouseHeld(GameObject.Find("Capsule"))))
            {
                UserAlgorithms.DragObject(GameObject.Find("Capsule"));
            }
        }
    }
}
