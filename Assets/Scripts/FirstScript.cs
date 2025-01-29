using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.1f;

    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public Spawner thingThatSpawnedMe;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer.color = Random.ColorHSV();

        if(sprites.Length == 0)
        {

        }
        else
        {
            spriteRenderer.sprite = sprites[Random.Range(0,sprites.Length)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x < 0)
        {
            Vector2 fixedPos = new Vector2(0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        if(screenPos.x > Screen.width)
        {
            Vector2 fixedPos = new Vector2(Screen.width, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
