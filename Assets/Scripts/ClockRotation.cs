using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.U2D;

public class ClockRotation : MonoBehaviour
{
    public GameObject bird;
    public float rotSpeed;
    public AudioSource clockSound;
    public AudioClip clockClip;
    public float time;

   //public bool startSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.eulerAngles;
        pos.z += -rotSpeed * Time.deltaTime;
        transform.eulerAngles = pos;

        if (Mathf.Round(transform.eulerAngles.z % 30) == 0)
        {
            if (!clockSound.isPlaying)
            {
                clockSound.PlayOneShot(clockClip);
                bird.SetActive(true);
            }
        }
        else
        {
                bird.SetActive(false);
        }
    }
}
