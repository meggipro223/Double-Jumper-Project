using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreForBluePoles : MonoBehaviour {

    public static int BluePolesScore;
    public Text text;

	// Use this for initialization
	void Start () {

        BluePolesScore = 0;
	}
	
	// Update is called once per frame
	void Update () {

        text.text = BluePolesScore.ToString();

	}
}
