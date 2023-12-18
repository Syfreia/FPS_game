using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Public variable to set the lifetime of the bullet
    public float bulletLifetime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Destroy the bullet GameObject after the specified lifetime
        Destroy(gameObject, bulletLifetime);
    }

    // OnCollisionEnter is called when the bullet collides with another GameObject
    void OnCollisionEnter(Collision collision)
    {
        // Check if the bullet is of type 1 and collided with an object tagged as "EnemyType1"
        if (gameObject.CompareTag("BulletType1") && collision.gameObject.CompareTag("EnemyType1"))
        {
            // Destroy the enemy (e.g., bottle) GameObject
            Destroy(collision.gameObject);

            // Destroy the bullet GameObject
            Destroy(gameObject);
        }
        // Check if the bullet is of type 2 and collided with an object tagged as "EnemyType2"
        else if (gameObject.CompareTag("BulletType2") && collision.gameObject.CompareTag("EnemyType2"))
        {
            // Destroy the enemy (e.g., box) GameObject
            Destroy(collision.gameObject);

            // Destroy the bullet GameObject
            Destroy(gameObject);
        }
        // Check if the bullet is of type 3 and collided with an object tagged as "EnemyType3"
        else if (gameObject.CompareTag("BulletType3") && collision.gameObject.CompareTag("EnemyType3"))
        {
            // Destroy the enemy (e.g., sphere) GameObject
            Destroy(collision.gameObject);

            // Destroy the bullet GameObject
            Destroy(gameObject);
        }
    }
}
