using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	private PlayerController player;
	private ScoreController score;

    private bool respawned = false;
    public float respawnDelay;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
        score = FindObjectOfType<ScoreController> ();
	}

	// Update is called once per frame
	void Update () {
        if (player.dead && !respawned)
        {
            score.stop = true;
            respawned = true;
            RespawnPlayer();
        }
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		Debug.Log ("Player Respawn");
		yield return new WaitForSeconds (respawnDelay);

        GameObject[] gos = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject go in gos)
            Destroy(go);

        player.respawn();
        respawned = false;
        score.stop = false;
        score.resetScore();
	}
}