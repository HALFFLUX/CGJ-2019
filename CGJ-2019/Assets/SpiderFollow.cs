using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderFollow : MonoBehaviour
{
    public Vector3 lastPos;
    public Vector3 newPos;

    public GameObject Player;
    public SpriteRenderer sprites;
    public GameObject spider;
    public Animator spiderAnim;
    public NavMeshAgent navMesh;

    void Start()
    {
        spider = gameObject;
        navMesh = GetComponent<NavMeshAgent>();
        spiderAnim = GetComponentInChildren<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player");
        sprites = GetComponentInChildren<SpriteRenderer>();
    }

    
    void Update()
    {
        if (Vector3.Distance(spider.transform.position, Player.transform.position) < 25)
            navMesh.destination = Player.transform.position;


        newPos = spider.transform.position;
        if (newPos != lastPos)
        {
            spiderAnim.SetBool("isMoving", true);

        }
        else if (newPos == lastPos)
            spiderAnim.SetBool("isMoving", false);

        if (newPos.z < lastPos.z)
            spiderAnim.SetBool("Vertical", false);
        else if (newPos.z > lastPos.z)
            spiderAnim.SetBool("Vertical", true);

        if (newPos.x < lastPos.x)
        {

            sprites.flipX = true;
            spiderAnim.SetBool("Horizontal", false);
        }
        else if (newPos.x > lastPos.x)
        {
            sprites.flipX = false;
            spiderAnim.SetBool("Horizontal", true);

        }
        lastPos = newPos;
    }
}
