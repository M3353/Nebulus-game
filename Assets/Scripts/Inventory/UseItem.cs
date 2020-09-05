using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UseItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private DialogueItems inventorydescript;
    private DialogueManager mainDialogue;
    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
        inventorydescript = GetComponent<DialogueItems>();
        mainDialogue = GameObject.FindGameObjectWithTag("MainDialogue").GetComponent<DialogueManager>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        inventorydescript.TriggerDialogue();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        inventorydescript.EndDialogue();
    }

    public void ClickedItemKeyCard()
    {
        if (GlobalVar.isCollidingStartDoor)
        {
            mainDialogue.EndDialogue();
            aud.Play();
            Destroy(GameObject.Find("StartRoomDoor").GetComponent<DialogueTrigger>());
            GameObject.Find("UnlockableWall1").GetComponent<BoxCollider2D>().isTrigger = true;
            GlobalVar.isCollidingStartDoor = false;
        }
    }

    public void ClickedItemEngineerKey()
    {
        if (GlobalVar.isCollidingGenDoor)
        {
            mainDialogue.EndDialogue();
            aud.Play();
            Destroy(GameObject.Find("GeneratorRoomDoor").GetComponent<DialogueTrigger>());
            GameObject.Find("UnlockableWall2").GetComponent<BoxCollider2D>().isTrigger = true;
            GlobalVar.isCollidingGenDoor = false;
        }

    }

    public void ClickItemMysteryKey()
    {
        if (GlobalVar.isCollidingCloneDoor)
        {
            mainDialogue.EndDialogue();
            aud.Play();
            Destroy(GameObject.Find("CloneRoomDoor").GetComponent<DialogueTrigger>());
            GameObject.Find("UnlockableWall3").GetComponent<BoxCollider2D>().isTrigger = true;
            GlobalVar.isCollidingCloneDoor = false;
        }
    }

}

