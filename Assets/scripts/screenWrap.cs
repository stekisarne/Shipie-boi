﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenWrap : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position; //skapar en vector3 variabel och sätter värdet till båtens position

        if (newPosition.x > 8f || newPosition.x < -8f) //kollar om newPosition på x axeln är mer än 8 eller mindre än -8
        {
            newPosition.x = -newPosition.x; //sätter newPosition på x axeln till motsatta värde
        }

        if (newPosition.y > 5f || newPosition.y < -5f) //kollar om newPosition på y axeln är mer än 5 eller mindre än -5
        {
            newPosition.y = -newPosition.y; //sätter newPosition på y axeln till motsatta värde
        }

        transform.position = newPosition; //sätter skeppets position till newPosition
    }
}
