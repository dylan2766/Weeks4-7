using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveFood : MonoBehaviour
{
    //Variables
    public Transform start;
    public Transform end;

    public float xEnd;
    public float xStart;

    public float speed;
    public Slider sliderSpeed;

    public SelectionValue selection;

    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    public Spawner foodSpawner;

    Transform xPos;
    // Start is called before the first frame update
    void Start()
    {
        //References tranforms
        xPos = GetComponent<Transform>();

        spriteRenderer.sprite = sprites[selection.selectionValue];

        speed = sliderSpeed.value;
    }

    // Update is called once per frame
    void Update()
    {
        //slider speed value
        speed = sliderSpeed.value;

        //Moves food
        xPos.transform.position = transform.position;

        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        //Setting start and end positions.
        xEnd = end.position.x;
        xStart = start.position.x;

        //Resets location to start if sprite passes end pos
        if (xPos.transform.position.x > xEnd)
        {
            xPos.transform.position = start.position;
        }
        transform.position = pos;
    }
}
