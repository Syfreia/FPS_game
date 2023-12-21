using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public static Color bulletColor = Color.blue;
    public static string tagname = "BulletType1";
    public GameObject keypad;
    public GameObject bulletPrefab;
    private int bulletType = 1;
    public float interactDistance = 10f; // Adjust this value based on your scene


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Check if the player is near the keypad
            float distanceToKeypad = Vector3.Distance(transform.position, keypad.transform.position);
            if (distanceToKeypad <= interactDistance)
            {
                // Change the bullet type
                ChangeBulletType();
            }
        }
    }
    
    void ChangeBulletType()
    {
        // Increment the bullet type
        bulletType++;

        // Wrap the bullet type back to 1 if it exceeds 3
        if (bulletType > 3)
        {
            bulletType = 1;
        }

        switch (bulletType)
        {
            case 1:
                tagname = "BulletType1";
                bulletColor = Color.blue;
                break;
            case 2:
                tagname = "BulletType2";
                bulletColor = Color.red;
                break;
            case 3:
                tagname = "BulletType3";
                bulletColor = Color.black;
                break;
            default:
                tagname = "BulletType1";
                bulletColor = Color.blue;
                break;
        }
    }
}