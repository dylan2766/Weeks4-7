using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject prefab;

    public List<GameObject> foodSpawned;

    public SpawnCondition on;

    public float t;
    // Start is called before the first frame update
    void Start()
    {
        foodSpawned = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (on.spawnOn == 1 && t !< 4.99)
        {
            GameObject spawnFood = Instantiate(prefab, transform.position, Quaternion.identity);

            foodSpawned.Add(spawnFood);

            MoveFood foodScript = spawnFood.GetComponent<MoveFood>();

            //foodScript.spawned = this;

            if (transform.position.x >= foodScript.xEnd)
            {
                Destroy(spawnFood);
            }
        }

        t += Time.deltaTime;

        if (t >= 5)
        {
            t = 0;
        }
    }
}
