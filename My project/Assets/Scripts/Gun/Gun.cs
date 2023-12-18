using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform muzzle;           // The position where bullets are spawned
    public GameObject bulletPrefab;    // Prefab of the bullet GameObject
    public float bulletForce = 20f;    // Force applied to the bullet when fired
    public float fireRate = 0.2f;      // Time delay between consecutive shots

    // Private variable to control firing rate
    private bool canFire = true;

    // Update is called once per frame
    void Update()
    {
        // Check if the right mouse button is pressed and the gun can fire
        if (Input.GetMouseButton(0) && canFire)
        {
            // Call the Fire method to shoot a bullet
            Fire();
            // Set canFire to false to prevent rapid firing
            canFire = false;

            // Start a coroutine to reset the firing rate after a delay
            StartCoroutine(ResetFireRate());
        }
    }

    // Method to instantiate and shoot a bullet
    void Fire()
    {
        // Instantiate a bullet at the muzzle position with the muzzle rotation
        GameObject bullet = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        
        // Get the bullet's Rigidbody component
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        
        // Apply force to the bullet in the forward direction of the muzzle
        bulletRigidbody.AddForce(muzzle.forward * bulletForce, ForceMode.Impulse);
    }

    // Coroutine to reset the canFire variable after a specified delay
    IEnumerator ResetFireRate()
    {
        
        // Wait for the specified fire rate delay
        yield return new WaitForSeconds(fireRate);
        
        // Set canFire back to true, allowing the gun to fire again
        canFire = true;
    }
}
