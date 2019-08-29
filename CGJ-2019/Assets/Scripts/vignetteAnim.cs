using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

[RequireComponent(typeof(eyeScript))]
public class vignetteAnim : MonoBehaviour
{
    public eyeScript eye;
    public PostProcessingProfile process;
    public float intensityx;
    float yVel = 0.0f;
    
    void Start()
    {

        
    }


    public void Update()
    {
        
        if (eye.eyeStatus == false)
        {
            intensityx = Mathf.SmoothDamp(.3f, .5f, ref yVel, 1f);
            VignetteModel.Settings vign = process.vignette.settings;
            vign.intensity = intensityx;
            process.vignette.settings = vign;


        } else if(eye.eyeStatus == true)
        {
            intensityx = Mathf.SmoothDamp(.5f, .3f, ref yVel, 1f);
            VignetteModel.Settings vign = process.vignette.settings;
            vign.intensity = intensityx;
            process.vignette.settings = vign;

        }


    }

    


        
}
