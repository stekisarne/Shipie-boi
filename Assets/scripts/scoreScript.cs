using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text scoreText;
    public int timeCount;
    public float timer;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime; //lägger til på timer hur lång tid det tog att slutföra förra framen 

        if (timer > timeCount) //kollar om timer är mer än timeCount
        {
            scoreText.text = timeCount.ToString(); //sätter texten till timeCount och även gör timeCount till en string

            timeCount = timeCount + 1; //lägger till en på timeCount

            print("Timer: " + timeCount); //skriver ut "Timer: x"
        }
	}
}
