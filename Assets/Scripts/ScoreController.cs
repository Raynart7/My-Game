using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

    private int score = 0;
    private int last_reset_time = 0;
    public Text score_text;

    public void resetScore()
    {
        score = 0;
        last_reset_time = (int) Time.realtimeSinceStartup;
    }

	// Use this for initialization
	void Start () {
        score_text.text = "";
    }

	// Update is called once per frame
	void Update () {
        score_text.text = "Score: " + score.ToString();
        score = (int) Time.realtimeSinceStartup - last_reset_time;
    }
}