using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScorePrototype : MonoBehaviour
{
    static public int score = 1000;

    void Awake() {
        // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("HighScorePrototype")) {
            score = PlayerPrefs.GetInt("HighScorePrototype");
        }
        
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScorePrototype", score);
    }

        void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;

        // Update the PlayerPrefs HighScore if necessary
        if (score > PlayerPrefs.GetInt("HighScorePrototype")) {
            PlayerPrefs.SetInt("HighScorePrototype", score);
        }
    }
}
