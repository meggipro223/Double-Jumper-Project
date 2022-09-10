using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRight : MonoBehaviour {

    public Rigidbody2D myBody;
    public float jumpForce = 10f;

    public enum State
    {
        normal,
        jumping
    }
    public State s;
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonDown(0) && Input.mousePosition.x > Screen.width / 2 && s == State.normal)
        {
            myBody.velocity = Vector2.right * jumpForce;
            s = State.jumping;
        }
	}

    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "Ground")
        {
            s = State.normal;
        }

        if(target.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameController>().EndGame();
            
        }
    }
}
