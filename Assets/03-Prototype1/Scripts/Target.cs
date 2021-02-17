using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float speed = 18f;

    public static float bottomY = -30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        position.y = position.y + (Time.deltaTime * speed);
        this.transform.position = position;

        if (transform.position.y < bottomY) {
            Destroy(this.gameObject);
        }
    }
}
