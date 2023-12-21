using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiMV2 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2.0f;

    private float t = 0f;

    void Update()
    {
        // Incrementa el parámetro t basado en el tiempo y la velocidad
        t += Time.deltaTime * speed;

        // Calcula la posición interpolada entre los puntos A y B
        Vector3 newPosition = Vector3.Lerp(pointA.position, pointB.position, t);

        // Asigna la nueva posición al enemigo
        transform.position = newPosition;

        // Si t supera 1, cambia los puntos A y B y reinicia t
        if (t > 1f)
        {
            Transform temp = pointA;
            pointA = pointB;
            pointB = temp;
            t = 0f;
        }
    }
}
