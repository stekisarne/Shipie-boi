using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovements : MonoBehaviour {

    public SpriteRenderer shipRend;
    public Color rightColor;
    public Color leftColor;
    public float rightRotation;
    public float leftRotation;
    public float forwardSpeed;
    
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        //när D är nertryckt så roterar skeppet åt höger och blir blå
        if (Input.GetKey(KeyCode.A))
        {
            shipRend.color = leftColor;
            transform.Rotate(0f, 0f, leftRotation * Time.deltaTime);
        }
        //när A är nertryckt så roterar skeppet åt vänster och blir grön
        if (Input.GetKey(KeyCode.D))
        {
            shipRend.color = rightColor;
            transform.Rotate(0f, 0f, rightRotation * Time.deltaTime);
        }
        //när S är nertryckt halverar farten
        if (Input.GetKeyDown(KeyCode.S))
        {
            forwardSpeed = forwardSpeed / 2;
        }
        //när S släpps igen går farten tillbaka
        if (Input.GetKeyUp(KeyCode.S))
        {
            forwardSpeed = forwardSpeed * 2;
        }
        //gör så att skeppet rör sig framåt hela tiden
        transform.Translate(forwardSpeed * Time.deltaTime, 0, 0, Space.Self);
    }
}
