using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script monitors game state.
public class GameState : MonoBehaviour
{
    public static bool playerWon = false;
    public static bool playerLost = false;
    
    public static bool flagToldPlayerWon = false;//Ensures the player is notified only once
    public static bool flagToldPlayerLost = false;//Ensures the player is notified only once
    private string userName = KeyBoardMain.typedText;// Gets username from the main menu
    public static int playerScore = 0;

    public GameObject winButton;
    public GameObject loseButton;

    // Update is called once per frame
    void Update()
    {
        //Checks to see if player has won or lost.
        if(playerLost == true && flagToldPlayerLost != true)
        {
            Debug.Log("================--------------Player Lost--------------================");
            Debug.Log("Player Score: " + playerScore);
            flagToldPlayerLost = true;
            POST.httpRequestPost2048(userName, playerScore.ToString());
           
            Instantiate(loseButton).name = "LoseButton";
        }
        if (playerWon == true && flagToldPlayerWon != true)
        {
            Debug.Log("================--------------Player Won--------------================");
            Debug.Log("Player Score: " + playerScore);
            flagToldPlayerWon = true;
            POST.httpRequestPost2048(userName, playerScore.ToString());

            Instantiate(winButton).name = "WinButton";
        }
    }
}
