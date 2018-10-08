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
    public SpriteRenderer sRend;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public int randomSprite;

    // Use this for initialization
    void Start()
    {
        forwardSpeed = Random.Range(4, 11); //ger forwardSpeed ett slumpmässigt värde
        ySpawn = Random.Range(-4.02f, 4.02f); //skapar ett slumpmässigt tal
        xSpawn = Random.Range(-7.98f, 8.01f); //skapar ett slumpmässigt tal
        pos = new Vector2(xSpawn, ySpawn); //ger variabeln pos ett slumpmässigt värde
        transform.position = pos; //sätter positionen till pos
        randomSprite = Random.Range(1, 4);

        if (randomSprite == 1) //kollar om randomSprite = 1
        {
            sRend.sprite = sprite1; //sätter spriten till sprite1
        }

        else if(randomSprite == 2) //kollar om randomSprite = 2
        {
            sRend.sprite = sprite2; //sätter spriten till sprite2
        }

        else 
        {
            sRend.sprite = sprite3; //sätter spriten till sprite3
        }
    }
    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKey(KeyCode.A)) //kollar om du trycker på "A"
        {
            shipRend.color = leftColor; //sätter färgen på skeppet till leftColor
            transform.Rotate(0f, 0f, leftRotation * Time.deltaTime); //roterar skeppet åt leftRotation
        }
        
        
        if (Input.GetKey(KeyCode.D)) //kollar om du trycker på "D"
        {
            shipRend.color = rightColor; //sätter färgen på skeppet till rightColor
            transform.Rotate(0f, 0f, rightRotation * Time.deltaTime); //roterar skeppet åt rightRotation
        }
        
        
        if (Input.GetKeyDown(KeyCode.S)) //kollar om "S" är nertryckt
        {
            forwardSpeed = forwardSpeed / 2; //sätter farten till hälften
        }
        
        
        if (Input.GetKeyUp(KeyCode.S)) //kollar om "S" är släppt igen
        {
            forwardSpeed = forwardSpeed * 2; //sätter farten tillbaka till förra farten
        }
        
        
        transform.Translate(forwardSpeed * Time.deltaTime, 0, 0, Space.Self); //skickar fram skeppet hela tiden i forwardSpeed fart
        
        
        if (Input.GetKeyDown(KeyCode.Space)) //kollar om "space" är nedtryckt 
        {
            red = Random.Range(0f, 1f); //ger red ett slumpmässigt värde
            green = Random.Range(0f, 1f); //ger green ett slumpmässigt värde
            blue = Random.Range(0f, 1f); //ger blue ett slumpmässigt värde

            spaceColor = new Color(red, green, blue); // ger spaceColor ett värde av en slumpmässig färg
            shipRend.color = spaceColor; //ger skeppet en slumpmässig färg
        }
    }
}
