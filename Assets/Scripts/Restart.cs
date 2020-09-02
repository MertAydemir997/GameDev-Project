using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // This function is used on the GameOver scene when you die in the Replay Level button. It sets your score to 0 everytime you die.
    public void replayLevel()
    {
        InfoSystem.score = 0;
        int prevLevel = PlayerController.currLevel;
        SceneManager.LoadScene(prevLevel);
    }
}
