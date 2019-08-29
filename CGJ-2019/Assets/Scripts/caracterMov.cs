using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class caracterMov : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    Vector3 offset = new Vector3(0, 0, 0);
    public float _zMov;
    public float _xMov;
    float speed = 5f;
    public Vector3 directions;
    public Vector3 velocity;

    void Start()
    {
        
    }





    void Update()
    {



        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime * speed;

        Debug.Log(velocity);

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * Time.deltaTime * speed;

        if ((Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)))
            speed = 4f;
        else
            speed = 5f;

       // rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);


        Debug.Log(rb.position.z);



    }
}
