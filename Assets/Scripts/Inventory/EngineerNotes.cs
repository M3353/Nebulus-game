using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New EngineerInstr Object", menuName = "Inventory System/Items/EngineerInstr")]
public class EngineerNotes : ItemObject
{
    public void Awake()
    {
        type = ItemType.EngineerInstr;
    }
}