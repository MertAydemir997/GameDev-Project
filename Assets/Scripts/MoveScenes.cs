using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes : MonoBehaviour
{
       // this function is used to move between levels. When all the enemies are defeated the player can move up the level via stairs.
       // The DontDestroyOnLoad makes sure the score and floor remain on the screen.
      void OnTriggerEnter2D(Collider2D other)
      {
        
        if (other.CompareTag("Player") && GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            GameObject canvas = GameObject.FindWithTag("Canvas");
            DontDestroyOnLoad(canvas);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }

      }
}
