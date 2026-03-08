// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_18
{
    public class TableLeg2Initializer : MonoBehaviour
    {
        public TableLeg2StateEnum initialState = TableLeg2StateEnum.Ready;

        void Awake()
        {
            TableLeg2StateStorage.Register(gameObject, initialState);
        }
    }
}
