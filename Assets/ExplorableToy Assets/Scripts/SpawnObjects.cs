using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour
{
    public GameObject food;
    public List<GameObject> spawnedFood;

    public GameObject spawnFood;

    public Slider foodSlider;

    public SpawnCondition on;

    public float t;

    public float foodSpeed;
    // Start is called before the first frame update
    void Start()
    {
        spawnedFood = new List<GameObject>();
        foodSpeed = foodSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(t) == 3 && on.spawnOn == 1)
        {
            t = 0;

            spawnFood = Instantiate(food, transform.position, Quaternion.identity);

            spawnedFood.Add(spawnFood);

            MoveFood foodScript = spawnFood.GetComponent<MoveFood>();

            foodSpeed = foodSlider.value;
            foodScript.speed = foodSpeed;

            foodScript.selection = spawnFood.GetComponent<SelectionValue>().selection;
            spawnFood.GetComponent<MoveFood>().selection = foodScript.selection;

            foodScript.foodSpawner = this;

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
