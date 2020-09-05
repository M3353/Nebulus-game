using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New KeyCard Object", menuName = "Inventory System/Items/KeyCard")]
public class KeyCard : ItemObject
{
    public void Awake()
    {
        type = ItemType.Keycard;
    }
}
