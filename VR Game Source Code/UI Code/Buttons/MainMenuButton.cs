using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    void OnTriggerEnter(Collider entityTriggered)
    {
        if (entityTriggered.gameObject.tag == "Controller")
        {
            SceneManager.LoadScene("Main");
        }
    }
}
