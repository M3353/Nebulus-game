using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New MeetingNotes Object", menuName = "Inventory System/Items/MeetingNotes")]
public class MeetingNotes : ItemObject
{
    public void Awake()
    {
        type = ItemType.MeetingNotes;
    }
}
