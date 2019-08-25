using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    private UsePortalObj portal;
    private Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private Vector2 backForce;
    private float vertical;
    private float horizontal;
    private bool isPaused = false;
    private bool areOpen = true;

    public GameObject PauseMenu;
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

        if (horizontal < 0f)
        {
            sprite.flipX = true;
            anim.SetBool("isMoveing", true);
        }
        else if(horizontal > 0f)
        {
            sprite.flipX = false;
            anim.SetBool("isMoveing", true);
        }
        else
        {
            anim.SetBool("isMoveing", false);
        }
        

        rb.velocity = new Vector2( horizontal * speed * Time.deltaTime , vertical  * speed * Time.deltaTime);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && isPaused == false)
        {
            anim.SetBool("isMoveing", false);
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }
        else if(Input.GetKeyDown(KeyCode.P) && isPaused == true)
        {
            anim.SetBool("isMoveing", false);
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        }

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

    
    

    public void StartNextScene(GameObject nextscene, GameObject curentscene)
    {
        curentscene.SetActive(false);
        nextscene.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Portal")
        {
            portal = collision.gameObject.GetComponent<UsePortalObj>();
            NextScene = portal.NextScene;
            CurentScene = portal.CurentScene;
            StartNextScene(NextScene , CurentScene);
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
