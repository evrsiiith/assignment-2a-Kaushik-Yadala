// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_26
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
