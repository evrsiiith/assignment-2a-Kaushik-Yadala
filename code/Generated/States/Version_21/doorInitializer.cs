// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_21
{
    public class doorInitializer : MonoBehaviour
    {
        public doorStateEnum initialState = doorStateEnum.Ready;

        void Awake()
        {
            doorStateStorage.Register(gameObject, initialState);
        }
    }
}
