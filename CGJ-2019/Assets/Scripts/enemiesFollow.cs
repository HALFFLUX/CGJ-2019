using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemiesFollow : MonoBehaviour
{
    public GameObject goblin;
    public GameObject player;
    public NavMeshAgent goblinMesh;
    public Animator goblinAnim;

    public Vector3 lastPos;
    public Vector3 newPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(goblin.transform.position, player.transform.position) < 15)
        goblinMesh.destination = player.transform.position;
        

        newPos = goblin.transform.position;
        if(newPos != lastPos)
        {
            goblinAnim.SetBool("isMoving", true);
            
        }
        else if(newPos == lastPos)
            goblinAnim.SetBool("isMoving", false);

        if (newPos.z < lastPos.z)
            goblinAnim.SetBool("Vertical", false);
        else if (newPos.z > lastPos.z)
            goblinAnim.SetBool("Vertical", true);

        if (newPos.x < lastPos.x)
        {

            goblin.GetComponentInChildren<SpriteRenderer>().flipX = true;
            goblinAnim.SetBool("Horizontal", false);
        }
        else if (newPos.x > lastPos.x)
        {
            goblin.GetComponentInChildren<SpriteRenderer>().flipX = false;
            goblinAnim.SetBool("Horizontal", true);

        }


        lastPos = newPos;
    }
}
