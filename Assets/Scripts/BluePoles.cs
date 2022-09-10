using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePoles : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreForBluePoles.BluePolesScore++;
        }
    }
}
