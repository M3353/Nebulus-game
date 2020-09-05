using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueItems : MonoBehaviour
{
    public Dialogue dialogue;
    private KeyCode next = KeyCode.E;
    private DialogueManager inventoryDescript;

    private void Awake()
    {
        inventoryDescript = GameObject.FindGameObjectWithTag("InventoryDescript").GetComponent<DialogueManager>();
    }
    public void TriggerDialogue()
    {
        inventoryDescript.StartDialogue(dialogue);
    }

    public void EndDialogue()
    {
        inventoryDescript.EndDialogue();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(next))
            {
                TriggerDialogue();
            }
        }
    }
}
