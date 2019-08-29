using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sprite;
    private bool eyesClosed = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("Horizontal", true);
                anim.SetBool("isMoving", true);
                sprite.flipX = false;
                anim.SetBool("Vertical", false);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("Horizontal", true);
                anim.SetBool("isMoving", true);
                anim.SetBool("Vertical", false);
                sprite.flipX = true;
            }
            

            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("Horizontal", false);
                anim.SetBool("Vertical", true);
                anim.SetBool("isMoving", true);
                if (Input.GetKey(KeyCode.A))
                {
                    sprite.flipX = true;
                }
                else
                {
                    sprite.flipX = false;
                }
                
            }
            else if (Input.GetKey(KeyCode.S))
            {
                if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("Horizontal", false);
                    anim.SetBool("Vertical", false);
                }
                else
                {
                    anim.SetBool("Horizontal", true);
                    anim.SetBool("Vertical", false);
                }
                anim.SetBool("isMoving", true);
                if (Input.GetKey(KeyCode.D))
                {
                    sprite.flipX = false;
                }
                else
                {
                    sprite.flipX = true;
                }
            }
            
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && eyesClosed == false)
        {
            anim.SetBool("OchiiInchisi", true);
            eyesClosed = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && eyesClosed == true)
        {
            anim.SetBool("OchiiInchisi", false);
            eyesClosed = false;
        }

        if (anim.GetBool("isMoving")){
            Debug.Log("Merge");
            //anim.SetBool("isMoving", false);
        }
        else
        {
            anim.SetBool("Horizontal", false);
            anim.SetBool("Vertical", false);
        }

    }
}
