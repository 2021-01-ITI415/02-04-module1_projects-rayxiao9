using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Prototype1 : MonoBehaviour
{
    static private Prototype1 S;
    [Header("Set in Inspector")]
    public int numShots = 10;
    public Text shotsGT;
    public GameObject GameOverText;

    private float timer = 5f;

    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
        GameObject shotsGO = GameObject.Find("ShotsLeft");

        shotsGT = shotsGT.GetComponent<Text>();

        shotsGT.text = "Shots Left: " + numShots;
    }

    // Update is called once per frame
    void Update()
    {
        shotsGT.text = "Shots Left: " + numShots;
        if (gameOver) {
            timer -= Time.deltaTime;
            S.GameOver();
        }
    }

    public static void ShotFired() {
        S.numShots--;

        if (S.numShots == 0) {
            Destroy(GameObject.FindWithTag("Slingshot"));
            S.GameOver();
            // SceneManager.LoadScene("Main-Prototype 1");
        }
    }

    void GameOver() {
        gameOver = true;
            GameOverText.SetActive(true);
        if (timer <= 0) {
            SceneManager.LoadScene("Main-Prototype 1");
        }
    }
}
