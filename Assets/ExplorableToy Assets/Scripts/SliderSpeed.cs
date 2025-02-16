using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSpeed : MonoBehaviour
{
    //Variables
    public float speed;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Set speed to the current slider value
        speed = slider.value;
    }
}
