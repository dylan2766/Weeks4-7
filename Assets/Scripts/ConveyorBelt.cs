using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConveyorBelt : MonoBehaviour
{
    //public AnimationCurve conveyorCurve;
    //public Transform start;
    //public Transform end;

    public float speed;
    public Slider sliderSpeed;

    //Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        sliderSpeed = GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {

        speed = sliderSpeed.value;

        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;


        //if(pos.x >= end.position.x)
        //{
        //    pos = start.position;
        //}


        //transform.position = Vector2.Lerp(start.position, end.position, conveyorCurve.Evaluate(speed));
    }
}
