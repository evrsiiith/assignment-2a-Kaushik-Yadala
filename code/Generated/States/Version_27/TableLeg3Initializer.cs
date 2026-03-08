// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_27
{
    public class TableLeg3Initializer : MonoBehaviour
    {
        public TableLeg3StateEnum initialState = TableLeg3StateEnum.Ready;

        void Awake()
        {
            TableLeg3StateStorage.Register(gameObject, initialState);
        }
    }
}
