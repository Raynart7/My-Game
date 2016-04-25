using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector2 (transform.position.x - speed, transform.position.y);
		if (transform.position.y < -2)
			Destroy(gameObject);
	}
}
