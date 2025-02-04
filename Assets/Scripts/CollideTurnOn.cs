using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollideTurnOn : MonoBehaviour
{
    public GameObject collision;
    public GameObject characterPos;
    public GameObject birb;
    public Collider2D birbCol;
    public Collider2D characterCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = characterPos.transform.position;

        Vector2 characterCollide = characterPos.transform.position;

        if (birbCol.isTrigger)
        {
            collision.SetActive(true);
        }
    }
}
