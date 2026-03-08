// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_26
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
