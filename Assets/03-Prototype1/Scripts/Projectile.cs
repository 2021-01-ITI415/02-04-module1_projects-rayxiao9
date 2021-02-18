using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public static float farX = 20f;
    public static float lowX = -20f;
    public static float bottomY = -10f;

    [Header("Set Dynamically")]
    public Text scoreGT;

    void Awake() {
        // Find a reference to the ScoreCounter GameObject
        GameObject scoreGO = GameObject.Find("ScoreCounter");

        // Get the Text Component of that GameObject
        scoreGT = scoreGO.GetComponent<Text>();
    }

    void Update() {
        if (transform.position.x > farX) {
            Destroy(this.gameObject);
        } else if (transform.position.x < lowX) {
            Destroy(this.gameObject);
        } else if (transform.position.y < bottomY) {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Target") {
            Destroy(collidedWith);
            int score = int.Parse(scoreGT.text);

            score += 100;

            scoreGT.text = score.ToString();

            if (score > HighScorePrototype.score) {
                HighScorePrototype.score = score;
            }
        }
    }
}
