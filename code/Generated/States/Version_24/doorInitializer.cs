// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_24
{
    public class doorInitializer : MonoBehaviour
    {
        public doorStateEnum initialState = doorStateEnum.Closed;

        void Awake()
        {
            doorStateStorage.Register(gameObject, initialState);
        }
    }
}
