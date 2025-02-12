using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int howManyTargets = 5;

    private void Start()
    {
        for(int i = 0; i < howManyTargets; i++)
        {
            GameObject newTarget = Instantiate(targetPrefab);
            newTarget.transform.position = Random.insideUnitCircle * 5;
        }
    }

}
