using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knobScript : MonoBehaviour
{
    public float forwardSpeed;

    // Use this for initialization
    void Start()
    {
        forwardSpeed = Random.Range(-5f, -9f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(forwardSpeed * Time.deltaTime, 0, 0, Space.Self);
    }
}
