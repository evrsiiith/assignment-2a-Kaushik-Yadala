// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_13
{
    public class rampInitializer : MonoBehaviour
    {
        public rampStateEnum initialState = rampStateEnum.Ready;

        void Awake()
        {
            rampStateStorage.Register(gameObject, initialState);
        }
    }
}
