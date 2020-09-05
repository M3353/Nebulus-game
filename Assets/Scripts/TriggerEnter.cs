using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    private CameraMove cam;
    private CameraMove UIcam;
    
    public Vector2 cameraDisplace;
    public Vector3 playerDisplace;

    private KeyCode W = KeyCode.W;
    private KeyCode S = KeyCode.S;

    private bool pressedW;
    private bool pressedS;
    private string entryWay;

    private void Start()
    {
        entryWay = gameObject.tag;
        pressedW = false;
        pressedS = false;
        cam = Camera.main.GetComponent<CameraMove>();
        UIcam = GameObject.Find("UI Camera").GetComponent<CameraMove>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(W))
        {
            pressedW = true;
        }
        else if (Input.GetKey(S))
        {
            pressedS = true;
        }   
        else
        {
            pressedW = false;
            pressedS = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (entryWay == "Door")
        {
            if (pressedW)
            {
                Displace(other);
            }
        }

        else if (entryWay == "StairsDown")
        {
            if (pressedS)
            {
                Displace(other);
            }
        }
    }


    private void Displace(Collider2D other)
    {
        cam.minPosition += cameraDisplace;
        cam.maxPosition += cameraDisplace;
        UIcam.minPosition += cameraDisplace;
        UIcam.maxPosition += cameraDisplace;
        other.transform.position += playerDisplace;
    }
}
