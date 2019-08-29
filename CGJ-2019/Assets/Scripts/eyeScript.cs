using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eyeScript : MonoBehaviour
{
    // false = opened, true = closed
    public bool eyeStatus = false;
    public GameObject particles;
    public Animator playerAnimator;
    public GameObject openEyes;
    public GameObject closedEyes;
    public Light lumina;
    public AudioSource audio;
    public AudioClip open;
    public AudioClip close;

    public Text eyeStatusText;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && eyeStatus == false)
        {
            openEyes.SetActive(false);
            closedEyes.SetActive(true);
            eyeStatusText.text = "CLOSED";
            eyeStatusText.color = Color.red;
            lumina.intensity = .3f;
            audio.PlayOneShot(close, 1.0f);
            eyeStatus = true;
            particles.SetActive(true);
            playerAnimator.SetBool("eyesOpen", false);

        }
        else if (Input.GetKeyDown(KeyCode.Space) && eyeStatus == true)
        {
            openEyes.SetActive(true);
            closedEyes.SetActive(false);
            eyeStatusText.text = "OPEN";
            eyeStatusText.color = Color.green;
            lumina.intensity = 2.3f;
            audio.PlayOneShot(open, 1.0f);
            eyeStatus = false;
            particles.SetActive(false);
            playerAnimator.SetBool("eyesOpen", true);
        }
    }
}
