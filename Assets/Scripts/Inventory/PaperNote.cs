using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PaperNote", menuName = "Inventory System/Items/PaperNote")]
public class PaperNote : ItemObject
{
    public void Awake()
    {
        type = ItemType.PaperNote;   
    }
}
