using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreForTheDistance : MonoBehaviour {

    public static int distanceScore;
    public float time = 0;
    public Text text;

	// Use this for initialization
	void Start () {

        distanceScore = 0;
	}
	
	// Update is called once per frame
	void Update () {

        SettingUpTime();
	}

    void SettingUpTime()
    {
        time = time + Time.deltaTime;

        if(time > 1)
        {
            time = 0;
            distanceScore++;
        }

        text.text = distanceScore.ToString();
    }
}
