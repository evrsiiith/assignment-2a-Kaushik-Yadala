// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_25
{
    public class CapsuleInitializer : MonoBehaviour
    {
        public CapsuleStateEnum initialState = CapsuleStateEnum.Free;

        void Awake()
        {
            CapsuleStateStorage.Register(gameObject, initialState);
        }
    }
}
