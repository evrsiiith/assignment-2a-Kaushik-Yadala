// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_22
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
