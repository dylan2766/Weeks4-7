using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionValue : MonoBehaviour
{
    //Variables
    public int selectionValue;

    public Button left;
    public Button right;

    // Start is called before the first frame update
    void Start()
    {
        selectionValue = 1;
    }

    // Update is called once per frame
    void Update()
    {

        //Sets inactive if button is at min or max value
        if (selectionValue <= 1)
        {
            left.enabled = false;
            left.interactable = false;
            selectionValue = 1;
        }
        else
        {
            left.enabled = true;
            left.interactable = true;
        }

        if (selectionValue >= 4)
        {
            right.enabled = false;
            right.interactable = false;
            selectionValue = 4;
        }
        else
        {
            right.enabled = true;
            right.interactable = true;
        }
    }
}
