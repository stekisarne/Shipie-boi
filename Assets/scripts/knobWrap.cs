using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knobWrap : MonoBehaviour
{
    public float randomizeY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        Vector3 randomY = transform.position;
        randomY.y = randomizeY;

        if (newPosition.x > 8f) 
        {
            randomizeY = Random.Range(5f, -5f);
            randomY.y = randomizeY;
            newPosition.x = -newPosition.x;
            newPosition.y = randomY.y;
        }

        if (newPosition.x < -8f) 
        {
            randomizeY = Random.Range(5f, -5f);
            randomY.y = randomizeY;
            newPosition.x = -newPosition.x;
            newPosition.y = randomY.y;
        }

        transform.position = newPosition; 
    }
}
