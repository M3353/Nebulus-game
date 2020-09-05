using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;

    public Text dialogueText;
    public Animator anim;
     private KeyCode next = KeyCode.E;

    private int sceneIndex;

    void Start()
    {
        sentences = new Queue<string>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        sentences.Enqueue("...");
    }

    public void Update()
    {
        if (Input.GetKeyDown(next))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue (Dialogue dialogue)
    {
        anim.SetBool("isOpen", true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        Debug.Log(sentences.Count);
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return 4;
        }
    }

    public void EndDialogue()
    {
        anim.SetBool("isOpen", false);

        if (sceneIndex == 1)
        {
            SceneManager.LoadScene(2);
        }

        if (sceneIndex == 3)
        {
            SceneManager.LoadScene(4);
        }
    }
}
