using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteHandRotation : MonoBehaviour
{
    public float rotSpeed;
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
    }
}
