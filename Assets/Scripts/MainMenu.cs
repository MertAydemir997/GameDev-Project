using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // A method which is used in the the Main Menu and End of Game Menu which enables buttons to start the first level of the game.
    public void playGame()
    {
    
        SceneManager.LoadScene(1);
    
    }
}
