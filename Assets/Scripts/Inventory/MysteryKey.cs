using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New MysteryKey Object", menuName = "Inventory System/Items/MysteryKey")]

public class MysteryKey : ItemObject
{
    public void Awake()
    {
        type = ItemType.MysteryKey;
    }
}
