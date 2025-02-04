using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Slider slider;
    float t;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        t += Time.deltaTime;
        slider.value = t % slider.maxValue;
    }
}
