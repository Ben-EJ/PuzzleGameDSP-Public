using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Contails details of sensor(Square in grid) and the cube on it.
public class CubeDetector : MonoBehaviour
{
    private bool cubeInSensor = false;
    private string cubeName = "";
    private int cubeValue = 0;
    public bool isCubeInSensor()
    {
        return cubeInSensor;
    }
    public string getCubeName()
    {
        return cubeName;
    }
    public void isCubeInSensorSet(bool set)
    {
        cubeInSensor = set;
    }
    public void setCubeName(string name)
    {
        cubeName = name;
    }
    public int getCubeValue()
    {
        return cubeValue;
    }
    public void setCubeValue(int value)
    {
        cubeValue = value;
    }
}
