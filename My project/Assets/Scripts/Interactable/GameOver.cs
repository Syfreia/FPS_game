    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string gameOverSceneName = "GameOverScene"; // Cambia esto al nombre de tu escena de "Game Over"

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que colisionó es el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Realiza acciones de "Game Over" (por ejemplo, muestra una pantalla de fin de juego, reproduce un sonido, etc.)
            Debug.Log("Game Over!");

            //Carga la escena de "Game Over" (debes crear una escena separada para la pantalla de fin de juego)
            SceneManager.LoadScene(gameOverSceneName);
        }
    }
}