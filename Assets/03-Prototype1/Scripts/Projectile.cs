using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public static float farX = 20f;
    public static float lowX = -20f;
    public static float bottomY = -10f;

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
        }
    }
}
