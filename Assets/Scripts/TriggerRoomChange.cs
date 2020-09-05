using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRoomChange : MonoBehaviour
{
    private CameraMove cam;
    private CameraMove UIcam;

    public Vector2 cameraDisplace;
    public Vector3 playerDisplace;

    private void Start()
    {
        cam = Camera.main.GetComponent<CameraMove>();
        UIcam = GameObject.Find("UI Camera").GetComponent<CameraMove>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
     cam.minPosition += cameraDisplace;
     cam.maxPosition += cameraDisplace;
     UIcam.minPosition += cameraDisplace;
     UIcam.maxPosition += cameraDisplace;
     other.transform.position += playerDisplace;

    }

}
