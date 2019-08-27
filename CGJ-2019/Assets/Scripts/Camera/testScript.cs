using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public Camera cam;
    private bool eyesclosed = false;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && eyesclosed == false)
        {
            Debug.Log(cam.cullingMask.ToString());
            cam.cullingMask = 511;
            eyesclosed = true;


        }
        else if(Input.GetKeyDown(KeyCode.Space) && eyesclosed == true)
        {
            Debug.Log(cam.cullingMask.ToString());
            cam.cullingMask = 567;
            eyesclosed = false;
        }
    }
}
