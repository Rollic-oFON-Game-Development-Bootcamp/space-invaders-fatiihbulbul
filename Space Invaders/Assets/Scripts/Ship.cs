using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 mouseXPosition = new Vector3(Input.mousePosition.x, 0, 0);
        mouseXPosition = Camera.main.ScreenToWorldPoint(mouseXPosition);
        transform.position = new Vector3(mouseXPosition.x, transform.position.y, transform.position.z);
    }
}
