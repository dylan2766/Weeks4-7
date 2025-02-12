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

    public SelectionValue foodSelection;

    public SpawnCondition on;

    public float t;

    public float foodSpeed;

    public int powered;
    // Start is called before the first frame update
    void Start()
    {
        spawnedFood = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        //Changes speed of prefab to match conveyor belt
        MoveFood foodScript2 = spawnFood.GetComponent<MoveFood>();

        if (on.spawnOn >= 1)
        {
            powered = 1;
        }
        else
        {
            powered = 0;
        }

        foodScript2.speed = foodSlider.value * powered;

        //if conveyor belt turned on and speed is greater than 0
        if (on.spawnOn == 1 && foodSlider.value > 0)
        {

            //tracks time
            t += Time.deltaTime;

            //round to nearest int is equal to 3 reset timer and spawn instance of prefab
            if (Mathf.Round(t) == 11 - foodSlider.value % 30)
            {
                t = 0;

                //Instantiate the prefab on the spawners position
                spawnFood = Instantiate(food, transform.position, Quaternion.identity);

                //Add instantiated object to list of spawned items
                spawnedFood.Add(spawnFood);

                MoveFood foodScript = spawnFood.GetComponent<MoveFood>();

                //Change loaded sprite
                foodScript.spriteRenderer.sprite = foodScript.sprites[foodSelection.selection - 1];

                foodScript.foodSpawner = this;
            }
        }
        else
        {
            t = 0;
        }
    }
    //Removes object from list
    public void deleteItem(GameObject t)
    {
        spawnedFood.Remove(t);
    }
}
