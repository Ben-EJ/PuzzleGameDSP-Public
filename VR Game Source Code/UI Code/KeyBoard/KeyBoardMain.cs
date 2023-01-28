using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardMain : MonoBehaviour
{
    public TextMesh threeDText;
    public static string typedText = "";//Saves text writen by user
    void OnTriggerEnter(Collider entityTriggered)
    {
        switch (entityTriggered.gameObject.name)
        {
            case "keyOne":
                typedText = typedText + "1";
                break;
            case "keyTwo":
                typedText = typedText + "2";
                break;
            case "keyThree":
                typedText = typedText + "3";
                break;
            case "keyFour":
                typedText = typedText + "4";
                break;
            case "keyFive":
                typedText = typedText + "5";
                break;
            case "keySix":
                typedText = typedText + "6";
                break;
            case "keySeven":
                typedText = typedText + "7";
                break;
            case "keyEight":
                typedText = typedText + "8";
                break;
            case "keyNine":
                typedText = typedText + "9";
                break;
            case "keyZero":

                break;


            case "keyQ":
                typedText = typedText + "Q";
                break;
            case "keyW":
                typedText = typedText + "W";
                break;
            case "keyE":
                typedText = typedText + "E";
                break;
            case "keyR":
                typedText = typedText + "R";
                break;
            case "keyT":
                typedText = typedText + "T";
                break;
            case "keyY":
                typedText = typedText + "Y";
                break;
            case "keyU":
                typedText = typedText + "U";
                break;
            case "keyI":
                typedText = typedText + "I";
                break;
            case "keyO":
                typedText = typedText + "O";
                break;
            case "keyP":
                typedText = typedText + "P";
                break;


            case "keyA":
                typedText = typedText + "A";
                break;
            case "keyS":
                typedText = typedText + "S";
                break;
            case "keyD":
                typedText = typedText + "D";
                break;
            case "keyF":
                typedText = typedText + "F";
                break;
            case "keyG":
                typedText = typedText + "G";
                break;
            case "keyH":
                typedText = typedText + "H";
                break;
            case "keyJ":
                typedText = typedText + "J";
                break;
            case "keyK":
                typedText = typedText + "K";
                break;
            case "keyL":
                typedText = typedText + "L";
                break;
            case "keyZ":
                typedText = typedText + "Z";
                break;
            case "keyX":
                typedText = typedText + "X";
                break;
            case "keyC":
                typedText = typedText + "C";
                break;
            case "keyV":
                typedText = typedText + "V";
                break;
            case "keyB":
                typedText = typedText + "B";
                break;
            case "keyN":
                typedText = typedText + "N";
                break;
            case "keyM":
                typedText = typedText + "M";
                break;
            case "keyBackSpace":
                typedText = typedText.Remove(typedText.Length - 1);
                break;
            default:
                break;
        }
        threeDText.text = typedText;
        Debug.Log(typedText);
    }
    
}
