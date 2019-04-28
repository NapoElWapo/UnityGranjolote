using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SlotTipos
{
    public enum SlotObjType {NONE, Ajolotes, Coleccionables, Herramientas, Pasivas }
}

public class SlotID: MonoBehaviour
{
    public SlotTipos.SlotObjType ActualSlotType = SlotTipos.SlotObjType.NONE;
}
