// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_13
{
    public class TableLeg1Initializer : MonoBehaviour
    {
        public TableLeg1StateEnum initialState = TableLeg1StateEnum.Ready;

        void Awake()
        {
            TableLeg1StateStorage.Register(gameObject, initialState);
        }
    }
}
