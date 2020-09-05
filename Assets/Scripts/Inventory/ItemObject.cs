using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Key,
    Keycard,
    MysteryKey,
    EngineerInstr,
    MeetingNotes,
    ScientistNotes,
    PaperNote,
}
public abstract class ItemObject: ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    public string description;
}
