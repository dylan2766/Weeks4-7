using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int howManyTargets = 5;
    public GameObject victoryGraphics;
    public SpriteRenderer victorySprite;
    public List<GameObject> targets;

    private void Start()
    {
        victorySprite.enabled = false;
        victoryGraphics.SetActive(false);

        targets = new List<GameObject>();
        for(int i = 0; i < howManyTargets; i++)
        {
            GameObject newTarget = Instantiate(targetPrefab);
            newTarget.transform.position = Random.insideUnitCircle * 5;

            Target t = newTarget.GetComponent<Target>();
            t.spawner = this;

            targets.Add(newTarget);
        }
    }

    private void Update()
    {
        if(targets.Count == 0)
        {
            victorySprite.enabled = true;
            victoryGraphics.SetActive(true);
        }
    }

    public void TargetHit(GameObject t)
    {
        targets.Remove(t);
    }

}
