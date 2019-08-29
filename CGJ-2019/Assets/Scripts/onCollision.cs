using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hi");
        anim.Play("bridgeAnim");
        Destroy(this);
    }
}
