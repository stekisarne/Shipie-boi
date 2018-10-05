using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovements : MonoBehaviour
{

    public SpriteRenderer shipRend;
    public Color rightColor;
    public Color leftColor;
    public Color spaceColor;
    public float rightRotation;
    public float leftRotation;
    public float forwardSpeed;
    public float red;
    public float green;
    public float blue;
    public float ySpawn;
    public float xSpawn;
    public Vector2 pos;

    // Use this for initialization
    void Start()
    {
        ySpawn = Random.Range(-4.02f, 4.02f);
        xSpawn = Random.Range(-7.98f, 8.01f);
        pos = new Vector2(xSpawn, ySpawn);
        transform.position = pos;
    }
    // Update is called once per frame
    void Update()
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
        
        //när du trycker space väljer den en slumpmässig färg
        if (Input.GetKeyDown(KeyCode.Space))
        {
            red = Random.Range(0f, 1f);
            green = Random.Range(0f, 1f);
            blue = Random.Range(0f, 1f);

            spaceColor = new Color(red, green, blue);
            shipRend.color = spaceColor;
        }
    }
}
