using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private KeyCode mleft = KeyCode.A;
    private KeyCode mright = KeyCode.D;

    private Animator anim;
    private Rigidbody2D rb;
    private Transform trans;
    private AudioSource aud;

    private float moveInput;
    private bool isMoving;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        moveInput = 0; 
        if (Input.GetKey(mright))
        {
            moveInput = 1;
            transform.localScale = new Vector2(1, 1);
        }
        else if (Input.GetKey(mleft))
        {
            moveInput = -1;
            transform.localScale = new Vector2(-1, 1);
        }
        
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        SoundTrigger();
        AnimationTrigger();
    }

    void AnimationTrigger()
    {
        anim.SetBool("walking", false);

        if (moveInput != 0)
            anim.SetBool("walking", true);
    }

    void SoundTrigger()
    {
        isMoving = false;
        
        if (rb.velocity.x != 0)
            isMoving = true;

        if (isMoving)
        {
            if (!aud.isPlaying)
            {
                aud.Play();
            }
        }
        else
        {
            aud.Stop();
        }   
    }

}
