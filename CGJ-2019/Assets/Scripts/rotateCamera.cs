using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour
{
    public GameObject player;
    public float speed = .1f;
    public bool interp = false;
    void Start()
    {

    }



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
             player.transform.eulerAngles = Vector3.Lerp(player.transform.eulerAngles, new Vector3(0, player.transform.eulerAngles.y + 180f, 0), speed);

        if (Input.GetKeyDown(KeyCode.E))
            player.transform.eulerAngles = Vector3.Lerp(player.transform.eulerAngles, new Vector3(0, player.transform.eulerAngles.y - 180f, 0), speed);

    }

}


