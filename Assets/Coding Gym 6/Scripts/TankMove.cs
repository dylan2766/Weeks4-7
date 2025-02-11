using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,0);

        Vector2 pos = transform.position;
        pos.x = transform.position.x;

        Vector2 screenPos = Camera.main.ScreenToWorldPoint(pos);

        if(screenPos.x > Screen.width)
        {
            pos.x = Screen.width;
        }
    }
}
