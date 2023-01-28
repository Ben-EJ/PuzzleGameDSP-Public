using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu2048 : MonoBehaviour
{
    void OnTriggerEnter(Collider entityTriggered)
    {
        if (entityTriggered.gameObject.tag == "Controller")
        {
            GameState.playerWon = false;
            GameState.playerLost = false;

            GameState.flagToldPlayerWon = false;//Ensures the player is notified only once
            GameState.flagToldPlayerLost = false;//Ensures the player is notified only once

            SceneManager.LoadScene("Main");
        }
    }
}
