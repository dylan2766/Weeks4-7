using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour
{
    public GameObject food;
    public List<GameObject> spawnedFood;

    public GameObject spawnFood;
    public MoveFood foodScript;

    public GameObject end;

    public Slider foodSlider;

    public SpawnCondition on;

    public float t;

    public float foodSpeed;
    // Start is called before the first frame update
    void Start()
    {
        spawnedFood = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (on.spawnOn == 1)
        {
            t += Time.deltaTime;

            if (Mathf.Round(t) == 3)
            {
                t = 0;

                spawnFood = Instantiate(food, transform.position, Quaternion.identity);

                spawnedFood.Add(spawnFood);

                MoveFood foodScript = spawnFood.GetComponent<MoveFood>();

                //Changes speed of prefab to match conveyor belt
                foodScript.speed = foodSlider.value;

                foodScript.foodSpawner = this;
            }
        }
        else
        {
            t = 0;
        }
        //Destorys the prefab after a certain amount of time (the lower the speed the more time to despawn)
        Destroy(spawnFood, 20 - (foodSlider.value * 1.25f));
    }
}
