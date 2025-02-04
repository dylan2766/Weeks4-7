using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollideTurnOn : MonoBehaviour
{
    //variables
    public GameObject collision;
    public GameObject characterPos;
    public GameObject birb;
    public Collider2D birbCol;
    public Rigidbody2D characterCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = characterPos.transform.position;

        Vector2 characterCollide = characterPos.transform.position;

        if (characterCol.IsTouching(birbCol))
        {
            collision.SetActive(true);
        }
        else
        {
            collision.SetActive(false);
        }
    }
}
