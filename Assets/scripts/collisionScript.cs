using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionScript : MonoBehaviour
{
    public Text Texteroni;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision2D)

    {
        if (collision2D.gameObject.name == "Ship")
        {
            Texteroni.text = "Game Over";
        }
    }
}
