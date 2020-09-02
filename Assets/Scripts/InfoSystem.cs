using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 0;
    Text scoretext;
    Text floortext;

    void Start()
    {
        // Gets the Text UI objects for the score and floor and recods them in a variable
        scoretext = GameObject.FindWithTag("ScoreText").GetComponent<Text>();
        floortext = GameObject.FindWithTag("FloorText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //updates the floor and score
        scoretext.text = "Score: " + score;
        floortext.text = SceneManager.GetActiveScene().name;
    }
}
