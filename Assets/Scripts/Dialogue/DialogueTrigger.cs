using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private DialogueManager dialogueManager;

    private void Awake()
    {
        dialogueManager = GameObject.FindGameObjectWithTag("MainDialogue").GetComponent<DialogueManager>();
    }
    public void TriggerDialogue()
    {
        dialogueManager.StartDialogue(dialogue);
    }

    public void StopDialogue()
    {
        dialogueManager.EndDialogue();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        string name = gameObject.name;
        if (name == "StartRoomDoor")
        {
            GlobalVar.isCollidingStartDoor = true;
        }
        else if (name == "GeneratorRoomDoor")
        {
            GlobalVar.isCollidingGenDoor = true;
        }
        else if (name == "CloneRoomDoor")
        {
            GlobalVar.isCollidingCloneDoor = true;
        }

        TriggerDialogue();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        GlobalVar.isCollidingStartDoor = false;
        GlobalVar.isCollidingGenDoor = false;
        GlobalVar.isCollidingCloneDoor = false;

        StopDialogue();
    }
}
