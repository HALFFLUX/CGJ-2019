using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private Vector2 backForce;
    private float vertical;
    private float horizontal;

    private bool areOpen = true;

    public GameObject CurentScene;
    public GameObject NextScene;
    public GameObject eyesOpen;
    public GameObject eyesClose;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (horizontal == -1f)
        {
            sprite.flipX = true;
        }
        else if(horizontal == 1f)
        {
            sprite.flipX = false;
        }
        

        rb.velocity = new Vector2( horizontal * speed , vertical  * speed );
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

    
    public void SetCurentGameObject(GameObject scene)
    {
        CurentScene = scene;
    }

    public void SetNextGameObject(GameObject scene)
    {
        NextScene = scene;
    }

    public void StartNextScene()
    {
        CurentScene.SetActive(false);
        NextScene.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "")
        {

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
