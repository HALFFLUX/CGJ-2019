using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class rotateEnemies : MonoBehaviour
{

    public GameObject enemies;
    public GameObject player;
    public float rot;
    void Start()
    {
        
    }

    
    void Update()
    {
        for(int i = 0; i < enemies.transform.childCount; i++)
        {
            enemies.transform.GetChild(i).GetComponentInChildren<Transform>().rotation = player.transform.rotation;


        }
    }
}
