using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveFood : MonoBehaviour
{
    //Variables
    public Transform end;
    public float xEnd;

    public float speed;
    public int selection;

    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    public SpawnObjects foodSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        xEnd = end.transform.position.x;

        //Moves food
        Vector2 pos = transform.position;
        pos.x += (speed * Time.deltaTime);

        transform.position = pos;
    }
}
