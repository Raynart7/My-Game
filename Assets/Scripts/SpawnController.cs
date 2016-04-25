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
        StartCoroutine(SpawnStuff());
    }

    IEnumerator SpawnStuff()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(low_rate, high_rate));
            Instantiate(spawn, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update () {
	}
}