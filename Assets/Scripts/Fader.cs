using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour
{
    private int gameIndex = 1;

    public Animator anim;
    public AudioSource aud;

    public void StartGame()
    {
        aud.Play();
        anim.SetTrigger("Fadeout");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(gameIndex);
    }
}
