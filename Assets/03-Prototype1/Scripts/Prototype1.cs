using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prototype1 : MonoBehaviour
{
    static private Prototype1 S;
    [Header("Set in Inspector")]
    public int numShots = 10;

    public Text shotsGT;

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
    }

    public static void ShotFired() {
        S.numShots--;
    }
}
