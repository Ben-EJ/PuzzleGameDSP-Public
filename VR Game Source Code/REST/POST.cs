using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

//Script contains functions that handle the post requests for each of the puzzles. Allows the score data and username to be sent to server.
public class POST : MonoBehaviour
{
    public static void httpRequestPost8Queens(string userName, string score)
    {
        Debug.Log("Sending 8 Queens data");
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://dsp.neb-ej.co.uk:10000/rest8QueensPost/");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            // Example: "{\"userName\" : \"RESTAPITEST\", \"score\":\"5000\"}"
            string jsonData = " {\"userName\" : " + "\"" + userName + "\"" + "," + "\"score\"" + ":\"" + score + "\"" + "} ";
            streamWriter.Write(jsonData);
        }
        Debug.Log("Sending POST");
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            Debug.Log(result);
        }
    }
    public static void httpRequestPost2048(string userName, string score)
    {
        Debug.Log("Sending 2048 Data");
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://dsp.neb-ej.co.uk:10000/rest2048Post/");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            // Example: "{\"userName\" : \"RESTAPITEST\", \"score\":\"5000\"}"
            string jsonData = " {\"userName\" : " + "\"" + userName + "\"" + "," + "\"score\"" + ":\"" + score + "\"" + "} ";
            streamWriter.Write(jsonData);
        }
        Debug.Log("Sending POST");
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            Debug.Log(result);
        }
    }


}
