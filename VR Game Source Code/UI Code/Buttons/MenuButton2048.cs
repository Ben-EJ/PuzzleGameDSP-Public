using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton2048 : MonoBehaviour
{
    void OnTriggerEnter(Collider entityTriggered)
    {
        if (entityTriggered.gameObject.tag == "Controller")
        {
            SceneManager.LoadScene("2048");
        }
    }
}
