﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New ScientistNote Object", menuName = "Inventory System/Items/ScientistNote")]
public class ScientistsNotes : ItemObject
{
    public void Awake()
    {
        type = ItemType.ScientistNotes;
    }
}
