using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonEightQueens : MonoBehaviour
{
    void OnTriggerEnter(Collider entityTriggered)
    {
        if (entityTriggered.gameObject.tag == "Controller")
        {
            SceneManager.LoadScene("EightQueensPuzzle");
        }
    }
}
