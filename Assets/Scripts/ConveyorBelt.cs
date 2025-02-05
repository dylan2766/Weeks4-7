using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConveyorBelt : MonoBehaviour
{
    public AnimationCurve conveyorCurve;
    public Transform start;
    public Transform end;

    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider = GetComponent<Slider>();

        float speed = slider.value * Time.deltaTime;
        speed = 2 * Time.deltaTime;

        Vector2 pos = transform.position;
        pos.x += 2 * Time.deltaTime;
        transform.position = pos;

        if(pos.x >= end.position.x)
        {
            pos = start.position;
        }

        //transform.position = Vector2.Lerp(start.position, end.position, conveyorCurve.Evaluate(speed));
    }
}
