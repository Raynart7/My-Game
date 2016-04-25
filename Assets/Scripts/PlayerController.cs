using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Player movement
	public float moveSpeed;
	public float jumpHeight;
    public bool dead = false;

	// Use this for initialization
	void Start () {
        transform.GetChild(0).GetComponent<ParticleSystem>().enableEmission = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!dead && col.gameObject.tag == "enemy")
        {
            transform.GetChild(0).GetComponent<ParticleSystem>().enableEmission = true;
            transform.Rotate(new Vector3(0, 0, 180));
            transform.GetComponent<Animator>().enabled = false;
            dead = true;
        }
    }

    public void respawn()
    {
        Debug.Log("dead?" + dead);
        dead = false;
        transform.GetChild(0).GetComponent<ParticleSystem>().enableEmission = false;
        transform.Rotate(new Vector3(0, 0, 180));
        transform.GetComponent<Animator>().enabled = true;
    }

    // Update is called once per frame
    void FixedUpdate () {

        if (transform.position.x < -5)
            transform.position = new Vector2(-5, transform.position.y);

        if (transform.position.x > 6)
            transform.position = new Vector2(6, transform.position.y);

        if (dead)
            return;

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
