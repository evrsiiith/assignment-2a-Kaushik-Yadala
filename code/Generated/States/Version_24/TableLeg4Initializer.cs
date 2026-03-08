// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_24
{
    public class TableLeg4Initializer : MonoBehaviour
    {
        public TableLeg4StateEnum initialState = TableLeg4StateEnum.Ready;

        void Awake()
        {
            TableLeg4StateStorage.Register(gameObject, initialState);
        }
    }
}
