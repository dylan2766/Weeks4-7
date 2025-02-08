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
    public Sprite[] foodSprites;
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        selectionValue = 1;
    }

    // Update is called once per frame
    void Update()
    {

        sprite = foodSprites[selectionValue -1];
        gameObject.GetComponent<Image>().sprite = sprite;

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

    //Subtract 1 if press left button
    public void pressLeft()
    {
        selectionValue = selectionValue - 1;
    }

    //Add 1 if press right button
    public void pressRight()
    {
        selectionValue = selectionValue + 1;
    }
}
