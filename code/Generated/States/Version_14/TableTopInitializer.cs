// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_14
{
    public class TableTopInitializer : MonoBehaviour
    {
        public TableTopStateEnum initialState = TableTopStateEnum.Ready;

        void Awake()
        {
            TableTopStateStorage.Register(gameObject, initialState);
        }
    }
}
