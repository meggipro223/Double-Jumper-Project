using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferedScore : MonoBehaviour {

    public Text text;

    private int s;
    private int d;
    private int transferedScore;

	// Use this for initialization
	void Start () {

        s = ScoreForBluePoles.BluePolesScore;
        d = ScoreForTheDistance.distanceScore;

        transferedScore = s * 3 + d;
        text.text = transferedScore.ToString();
	}
	
}
