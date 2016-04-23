using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

	public GameObject Spawn;
	public int rate;

	private bool spawnone = true; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		if ((int)Time.realtimeSinceStartup % rate == 0 && spawnone) {
			Instantiate (Spawn, transform.position, Quaternion.identity);
			spawnone = false;

		} else if ((int)Time.realtimeSinceStartup % rate !=0) 
		{
			spawnone = true;
		}
	}
}
