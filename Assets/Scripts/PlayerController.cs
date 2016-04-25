using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Player movement
	public float moveSpeed;
	public float jumpHeight;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (transform.position.x < -5)
            transform.position = new Vector2(-5, transform.position.y);

        if (transform.position.x > 6)
            transform.position = new Vector2(6, transform.position.y);

        //move right
        if (Input.GetKey(KeyCode.D)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		//move left
		if (Input.GetKey(KeyCode.A)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		//jump
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		}
						
	
	}
}
