using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QueensGameLogic : MonoBehaviour
{
    //Created a check box in the inspector pannel, when checked the script will run 
    //Without having to be in VR (FOR TESTING PERPOSES)
    //===================================================================
    public bool testButton = false;
    //===================================================================
    private string userName = KeyBoardMain.typedText;// Gets username from the main menu

    public GameObject winText;//Win text prefab
    public Text uiText;//Timer text object

    public List<GameObject> sensors = new List<GameObject>();
    public static List<Queen> queens = new List<Queen>();

    public Material matValidSolution;
    public Material matInvalidSolution;

    public bool puzzleSolved = false;

    public TimeSpan resultTime;
    public bool timerActive = false;
    public float time;

    public float score = 0;
    public float possibleScore = 1000;
    public int scoreModifyer = 10;

    private bool flagToMainMenu = false;
    private bool flagScorecalOnce = false;
    private bool buttonPreviouslyClicked = false;
    //Populates queens list, provides each queen with a name, possible moves array, and there current location (e.g A1)
    void populateQueensVars()
    {
        int queenNumber = 0;
        for (int i = 0; i < sensors.Count; i++)
        {
            if (sensors[i].GetComponent<DetectorScript>().queenInSensor == true)
            {
                queenNumber++;
                Queen aQueen = new Queen(queenNumber, sensors[i].GetComponent<DetectorScript>().queenName, PossibleMovesQueen.getPossibleMoves(sensors[i].name), sensors[i].name);
                queens.Add(aQueen);
            }
        }
    }

    //Checks line of sight for two provided queens to check if they can attack each other
    bool compareQueen(string firstQueen, List<string> queenToCompare)
    {
        for (int i = 0; i < queenToCompare.Count; i++)
        {
            if (firstQueen == queenToCompare[i])
            {
                return true;
            }
        }
        return false;
    }

    //Checks to see if any queens are in each others line of sight (possible moves)
    bool isInLineOfSightQueen()
    {
        //Get first queen to compare
        for (int i = 0; i < queens.Count; i++)
        {
            for (int x = 0; x < queens.Count; x++)
            {
                if (i != x)
                {
                    if (compareQueen(queens[i].getQueenXYChessCoords(), queens[x].getPossibleMoves()) == true)
                    {
                        Debug.Log("QUEEN ONE: " + queens[i].getQueenName());
                        Debug.Log("QUEEN TWO: " + queens[x].getQueenName());
                        return true;
                    }
                }

            }
        }
        return false;
    }

    //Checks to see if puzzle has been solved and updates colour of the button if it has.
    private void puzzleIsSolved()
    {
        if (queens.Count != 8 || isInLineOfSightQueen() == true)
        {
            Debug.Log("Invalid Solution");
            MeshRenderer my_renderer = GetComponent<MeshRenderer>();
            my_renderer.material = matInvalidSolution;
        }
        else
        {
            Debug.Log("Valid Solution");
            MeshRenderer my_renderer = GetComponent<MeshRenderer>();
            my_renderer.material = matValidSolution;
            puzzleSolved = true; //Sets true if the puzzle has been solved
        }
    }

    //Calculates player score
    public float calculateScore(int timeInput)
    {
        return possibleScore - (timeInput * scoreModifyer);
    }

    //Sends score data to webserver to be added to the database.
    private void sendScoreData()
    {
        if (puzzleSolved == true)
        {
            score = calculateScore(resultTime.Minutes);//Calculates user score
            Debug.Log("score: " + score);
            if (userName != "")//If the user did not enter a username in the main menu, then just send the username as guest
            {
                POST.httpRequestPost8Queens(userName, score.ToString());
            }
            else
            {
                Debug.Log("Setting up POST request");
                POST.httpRequestPost8Queens("Guest", score.ToString());
            }

        }
    }

    //When this function is called it sets the flagToMainMenu to true allowing the user to be taken back to the main menu
    private void toMainMenu()
    {
        SceneManager.LoadScene("Main");
    }

    //This functions perpose in this case is to fasilitate the use of the Test button I created in the unity editor 
    //so I dont have to test this script in vr
    private void testButtonFunc()
    {
        if (testButton == true)
        {
            puzzleSolved = false;
            if (puzzleSolved != true)
            {
                queens.Clear(); //Clear Queens list before generating new list. 
                populateQueensVars();//Gets queen location data from sensors and populates an list with data
                puzzleIsSolved();//Checks to see if the users solution is correct

                if (puzzleSolved == true && buttonPreviouslyClicked == false)
                {
                    Instantiate(winText);//Shows win text to user
                    sendScoreData();//Sends score data if puzzle is solved
                    buttonPreviouslyClicked = true;
                }
            }
        }
    }

    //This function is called when the Calculate solution button is clicked in game
    void OnTriggerEnter(Collider entityTriggered)
    {
        puzzleSolved = false;
        if (entityTriggered.gameObject.tag == "Controller" && puzzleSolved != true)
        {
            queens.Clear(); //Clear Queens list before generating new list. 
            populateQueensVars();//Gets queen location data from sensors and populates an list with data
            puzzleIsSolved();//Checks to see if the users solution is correct

            if (puzzleSolved == true && buttonPreviouslyClicked == false && queens.Count == 8)
            {
                Instantiate(winText);//Shows win text to user
                sendScoreData();//Sends score data if puzzle is solved
                buttonPreviouslyClicked = true;
            }
        }
    }

    private void Update()
    {
        testButtonFunc();
        if (timerActive == true)
        {
            time = time + Time.deltaTime;
        }
        resultTime = TimeSpan.FromSeconds(time);
        uiText.text = resultTime.Minutes.ToString() + ":" + resultTime.Seconds.ToString();

        //If user has solved the puzzle
        if (puzzleSolved == false)//If puzzle has not yet been solved, keep timer running
        {
            timerActive = true;//Starts timer
        }
        else if (puzzleSolved == true && flagScorecalOnce == false)//If puzzle has been solved (Prevents multiple exacutions of code, only need to be exacuted once)
        {
            timerActive = false;//Stops timer
            Invoke("toMainMenu", 5);//Takes user back to main menu after 10 seconds
            flagScorecalOnce = true;// Prevents this block of code from being exacuted more than once
        }
    }


    //For debugging ============================================================
    void debugFuncQueens()
    {
        for (int i = 0; i < queens.Count; i++)
        {
            Debug.Log("===========================================================================");
            Debug.Log("Queen Number: " + queens[i].getQueenNumber());
            Debug.Log("Queen Name: " + queens[i].getQueenName());
            PossibleMovesQueen.debugCalculateQueenMoves(queens[i].getQueenXYChessCoords());
            Debug.Log("Queen XY Coords: " + queens[i].getQueenXYChessCoords());
            Debug.Log("===========================================================================");
        }
    }

    void Start()
    {
        Debug.Log("Player Username: " + userName);
    }
}