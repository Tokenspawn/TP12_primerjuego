using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed;
    public float floorYValue;

    CajaSpawner cajaSpawner;

    void Start()
    {
        cajaSpawner = GetComponent<CajaSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed, 0);

        if(transform.position.y <= floorYValue)
        {
            cajaSpawner.LocateBoxAtRandomPosition();
        }
    }
}