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
        timer += Time.deltaTime;
        if (timer > timeCount)
        {
            scoreText.text = timeCount.ToString();
            timeCount = timeCount + 1;

            print("Timer: " + timeCount);
        }
	}
}
