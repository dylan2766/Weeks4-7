using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearRotation : MonoBehaviour
{
    //Variables
    public float rotSpeed;
    public Slider sliderSpeed;

    public SpawnCondition on;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gets value of slider to set as speed
        rotSpeed = sliderSpeed.value;

        if (on.spawnOn == 1)
        {
            Vector3 pos = transform.rotation.eulerAngles;
            pos.z += (-rotSpeed * 15) * Time.deltaTime;
            transform.eulerAngles = pos;
        }
    }
}
