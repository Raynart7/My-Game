using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

    public GameObject spawn;
    public int low_rate;
    public int high_rate;
    private int rate;

    private bool spawnone = true;

	// Use this for initialization
	void Start () {
        rate = Random.Range(low_rate, high_rate);
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(rate);

        if ((int) Time.realtimeSinceStartup % rate == 0 && spawnone)
        {
            Instantiate(spawn, transform.position, Quaternion.identity);
            spawnone = false;
        }
        else if ((int)Time.realtimeSinceStartup % rate != 0)
        {
            rate = Random.Range(low_rate, high_rate);
            spawnone = true;
        }
	}
}