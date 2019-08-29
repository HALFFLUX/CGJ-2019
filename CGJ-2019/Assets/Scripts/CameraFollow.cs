using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera cam;
    public GameObject player;
  //  public Animator playAnim;

    public string currentAnim = "Right";
    public ParticleSystem particle;

    Vector3 offset = new Vector3(0, 0, 0);
    void Start()
    {

    }


    void Update()
    {
        particle.transform.position = cam.transform.position;
/*
        if (Input.GetKey(KeyCode.D))
        {
            cam.transform.position = new Vector3(player.transform.position.x + 21.5f, player.transform.position.y + 28f, player.transform.position.z - 20f) + offset;

        }
        if (Input.GetKey(KeyCode.A))
        {
            cam.transform.position = new Vector3(player.transform.position.x + 21.5f, player.transform.position.y + 28f, player.transform.position.z - 20f) + offset;


        }

        if (Input.GetKey(KeyCode.W))
        {
            cam.transform.position = new Vector3(player.transform.position.x + 21.5f, player.transform.position.y + 28f, player.transform.position.z - 20f) + offset;


        }


        if (Input.GetKey(KeyCode.S))
        {
            cam.transform.position = new Vector3(player.transform.position.x + 21.5f, player.transform.position.y + 28f, player.transform.position.z - 20f) + offset;

        }
        */
     //   if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
    //s    {
          //  playAnim.SetBool("walking", true);
            
     //   }
    //    else
           // playAnim.SetBool("walking", false);

        }
    }

