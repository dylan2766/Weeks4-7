using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject prefab;

    public SpawnCondition on;

    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(t) == 5 && on.spawnOn == 1)
        {
            t = 0;

            GameObject spawnFood = Instantiate(prefab, transform.position, Quaternion.identity);

            MoveFood foodScript = GetComponent<MoveFood>();

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
