using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D rb;

    private Vector2 backForce;
    private float vertical;
    private float horizontal;

    private bool areOpen = true;

    public GameObject eyesOpen;
    public GameObject eyesClose;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Horizontal");
        horizontal = Input.GetAxis("Vertical");

        rb.velocity = new Vector2( vertical * speed , horizontal * speed );
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && areOpen == true)
        {
            eyesClose.SetActive(true);
            eyesOpen.SetActive(false);
            areOpen = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && areOpen == false)
        {
            eyesOpen.SetActive(true);
            eyesClose.SetActive(false);
            areOpen = true;
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.name == "block" && collision.transform.position.x <= transform.position.x 
    //        && collision.transform.position.y <= transform.position.y)
    //    {
    //        backForce.x = 500f;
    //        backForce.y = 500f;
    //        rb.AddForce(backForce);
    //    }
    //    else if (collision.gameObject.name == "block" && collision.transform.position.x > transform.position.x
    //        && collision.transform.position.y <= transform.position.y)
    //    {
    //        backForce.x = 500f;
    //        backForce.y = 500f;
    //        rb.AddForce(backForce);
    //    }
    //    else if (collision.gameObject.name == "block" && collision.transform.position.x <= transform.position.x
    //        && collision.transform.position.y > transform.position.y)
    //    {
    //        backForce.x = 500f;
    //        backForce.y = 500f;
    //        rb.AddForce(backForce);
    //    }
    //    else if (collision.gameObject.name == "block" && collision.transform.position.x > transform.position.x
    //        && collision.transform.position.y > transform.position.y)
    //    {
    //        backForce.x = 500f;
    //        backForce.y = 500f;
    //        rb.AddForce(backForce);
    //    }

    //}
}
