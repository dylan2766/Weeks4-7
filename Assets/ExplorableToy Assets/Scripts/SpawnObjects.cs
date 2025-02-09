using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour
{
    //Variables
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
        //if conveyor belt turned on and speed is greater than 0
        if (on.spawnOn == 1 && foodSlider.value > 0)
        {
            //tracks time
            t += Time.deltaTime;

            //round to nearest int is equal to 3 reset timer and spawn instance of prefab
            if (Mathf.Round(t) == 3)
            {
                t = 0;

                //Instantiate the prefab on the spawners position
                spawnFood = Instantiate(food, transform.position, Quaternion.identity);

                //Add instantiated object to list of spawned items
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
