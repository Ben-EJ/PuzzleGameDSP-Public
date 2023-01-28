using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script detects if a queen is on a given square on the chess board.
public class DetectorScript : MonoBehaviour
{
    public bool queenInSensor = false;
    public string queenName = "";
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Queen")
        {
            queenInSensor = true;
            queenName = collision.gameObject.name;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Queen")
        {
            queenInSensor = false;
            queenName = "";
        }
    }
}