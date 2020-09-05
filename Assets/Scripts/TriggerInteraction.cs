using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    public GameObject helper;
    private GameObject _instance;

    public float X_OFFSET;
    public float Y_OFFSET;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!helper.activeInHierarchy)
        {
            _instance = Instantiate(helper, Vector3.zero, Quaternion.identity, transform);
            _instance.GetComponent<RectTransform>().localPosition = new Vector3(X_OFFSET, Y_OFFSET, -1.0f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(_instance);
    }


}
