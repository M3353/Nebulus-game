using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVar : MonoBehaviour
{
    public static bool isCollidingStartDoor;
    public static bool isCollidingGenDoor;
    public static bool isCollidingCloneDoor;

    public void Awake()
    {
        isCollidingCloneDoor = false;
        isCollidingGenDoor = false;
        isCollidingStartDoor = false;
    }
}
