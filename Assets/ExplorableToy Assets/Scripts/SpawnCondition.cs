using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCondition : MonoBehaviour
{
    //Variables
    public int spawnOn;
    public Button power;
    public Sprite[] powerSprites;
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        spawnOn = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnOn == -1)
        {
            sprite = powerSprites[0];
            gameObject.GetComponent<Image>().sprite = sprite;
        }

        if (spawnOn == 1)
        {
            sprite = powerSprites[1];
            gameObject.GetComponent<Image>().sprite = sprite;
        }
    }

    //button to turn on and off
    public void powerSwitch()
    {
        spawnOn = spawnOn * -1;
    }

}
