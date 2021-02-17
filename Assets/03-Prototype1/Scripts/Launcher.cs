using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject   targetPrefab;

    // Speed at which the AppleTree moves
    public float        speed = 1f;

    // Distance where AppleTree turns around
    public float        leftAndRightEdge = 10f;

    // Chance that the AppleTree will change directions
    public float        chanceToChangeDirections = 0.1f;

    // Rate at which Apples will be instantiated
    public float        secondsBetweenTargetLaunch = 1f;

    void Start () {
        // Dropping apples every second  
        Invoke("LaunchTarget", 2f);
    }

    void LaunchTarget() {
        GameObject target = Instantiate<GameObject>(targetPrefab);
        target.transform.position = transform.position;
        Invoke("LaunchTarget", secondsBetweenTargetLaunch);
        }

    void Update () {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        } else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    void FixedUpdate(){
        // Changing Direction Randomly is now time-based because ofFixedUpdate()
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
