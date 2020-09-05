using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollide : MonoBehaviour
{
    private KeyCode pickup = KeyCode.E;

    public DialogueManager dialogue;
    public InventoryObject inventory;
    public GameObject prefab;

    private GameObject _instance;

    public void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            DeleteThis();
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            if (Input.GetKey(pickup))
            {
                Destroy(other.gameObject);
                inventory.AddItem(item.item, 1);

                if (other.name == "KeyCard")
                {
                    _instance = Instantiate(prefab);
                }

                if (other.name == "ScientistNotes")
                {
                    SceneManager.LoadScene(3);
                }
            }
        }
    }

    public void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }

    public void DeleteThis()
    {
        dialogue.EndDialogue();
        Destroy(_instance);
    }
}
