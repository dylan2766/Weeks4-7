using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject food;
    public List<GameObject> spawnedFood;

    public SpawnCondition on;

    public float t;
    // Start is called before the first frame update
    void Start()
    {
        spawnedFood = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(t) == 3 && on.spawnOn == 1)
        {
            t = 0;

            GameObject spawnFood = Instantiate(food, transform.position, Quaternion.identity);

            spawnedFood.Add(spawnFood);

            MoveFood foodScript = spawnFood.GetComponent<MoveFood>();
            foodScript.sliderSpeed = spawnFood.GetComponent<SliderSpeed>().slider;
            foodScript.speed = spawnFood.GetComponent<SliderSpeed>().speed;
            foodScript.selection = spawnFood.GetComponent<SelectionValue>();
            //foodScript.foodSpawner = this;


            if (transform.position.x >= foodScript.xEnd)
            {
                Destroy(spawnFood);
            }
        }

        if (on.spawnOn == 1)
        {
            t += Time.deltaTime;
        }
        else
        {
            t = 0;
        }
    }
}
