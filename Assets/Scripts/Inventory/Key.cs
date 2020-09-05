using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Key Object", menuName = "Inventory System/Items/Key")]
public class Key : ItemObject
{
     public void Awake()
    {
        type = ItemType.Key;
    }
}
