// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_24
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
