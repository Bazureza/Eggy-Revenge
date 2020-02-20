using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCountDown : MonoBehaviour {
    float timeLeft = 30.0f;
    private string score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GetComponent<GUIText>().text = "Score: " + score;
        }
    }
}
