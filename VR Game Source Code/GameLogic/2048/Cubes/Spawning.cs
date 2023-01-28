using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script spawns 2 cubes at the start of puzzle.
public class Spawning : MonoBehaviour
{
    public GameObject cube2GameObj;
    public static int cubeCounter = 0;
    public static float spawnHeight = 0.01f;
    void Start()
    {
        int pos1rnd = 0;
        int pos2rnd = 0;

        string pos1;
        string pos2;
        System.Random rnd = new System.Random();
        Grid grid = new Grid();
        pos1rnd = rnd.Next(0, 16);//Generate random position for cube 1
        pos2rnd = rnd.Next(0, 16);//Generate random position for cube 2

        while (pos1rnd == pos2rnd)// Check to see if they are the same, if they are, choose a new position for cube 2, until they are not.
        {
            pos2rnd = rnd.Next(0, 16);
        }

        pos1 = grid.gridWhole[pos1rnd]; //Converts randomly generated number into the name of a sensor
        pos2 = grid.gridWhole[pos2rnd]; //Converts randomly generated number into the name of a sensor

        GameObject sensor = GameObject.Find(pos1);//Gets the sensors game object
        GameObject sensor2 = GameObject.Find(pos2);//Gets the sensors game object

        Vector3 objPos1 = sensor.transform.position;//Gets position of sensor
        Vector3 objPos2 = sensor2.transform.position;//Gets position of sensor

        Vector3 cubeSpawnPos1 = new Vector3(objPos1.x, objPos1.y + spawnHeight, objPos1.z);//Creates postion of cube
        Vector3 cubeSpawnPos2 = new Vector3(objPos2.x, objPos2.y + spawnHeight, objPos2.z);//Creates postion of cube

        Quaternion rotationOfCube = new Quaternion();//Creates rotation of cube
        rotationOfCube.x = 0;
        rotationOfCube.y = 180;
        rotationOfCube.z = 0;
        
        cubeCounter = cubeCounter + 1;
        string cube1Name = "cube" + cubeCounter;
        Instantiate(cube2GameObj, cubeSpawnPos1, rotationOfCube).name = cube1Name;//Spawns cube 1

        cubeCounter = cubeCounter + 1;
        string cube2Name = "cube" + cubeCounter;
        Instantiate(cube2GameObj, cubeSpawnPos2, rotationOfCube).name = cube2Name;//Spawns cube 2

        //Sets details of cubes in their respective sensors.
        sensor.GetComponent<CubeDetector>().setCubeName(cube1Name);
        sensor2.GetComponent<CubeDetector>().setCubeName(cube2Name);

        sensor.GetComponent<CubeDetector>().isCubeInSensorSet(true);
        sensor2.GetComponent<CubeDetector>().isCubeInSensorSet(true);

        sensor.GetComponent<CubeDetector>().setCubeValue(2);
        sensor2.GetComponent<CubeDetector>().setCubeValue(2);
    }
}
