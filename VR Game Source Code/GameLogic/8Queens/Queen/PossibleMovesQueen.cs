using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
===================================================================
Script Name	: Possible Moves Queen                                                                                              
Description	: This script calculates possible moves for a single queen on the board.                                                                                                                                                                          
Author      : Benjamin Ell-Jones                                                                                         
===================================================================
*/
public class PossibleMovesQueen : MonoBehaviour
{
    private static List<string> chessBoardA = new List<string>() { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8" };
    private static List<string> chessBoardB = new List<string>() { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8" };
    private static List<string> chessBoardC = new List<string>() { "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8" };
    private static List<string> chessBoardD = new List<string>() { "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8" };
    private static List<string> chessBoardE = new List<string>() { "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8" };
    private static List<string> chessBoardF = new List<string>() { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8" };
    private static List<string> chessBoardG = new List<string>() { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8" };
    private static List<string> chessBoardH = new List<string>() { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8" };

    private static List<string> chessBoard1 = new List<string>() { "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1" };
    private static List<string> chessBoard2 = new List<string>() { "A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2" };
    private static List<string> chessBoard3 = new List<string>() { "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3" };
    private static List<string> chessBoard4 = new List<string>() { "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4" };
    private static List<string> chessBoard5 = new List<string>() { "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5" };
    private static List<string> chessBoard6 = new List<string>() { "A6", "B6", "C6", "D6", "E6", "F6", "G6", "H6" };
    private static List<string> chessBoard7 = new List<string>() { "A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7" };
    private static List<string> chessBoard8 = new List<string>() { "A8", "B8", "C8", "D8", "E8", "F8", "G8", "H8" };

    private static List<string> chessCoordsXAxis = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H" };
    private static List<string> chessCoordsYAxis = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8" };

    private static List<string> chessCoordsXAxisReverced = new List<string>() { "H", "G", "F", "E", "D", "C", "B", "A" };
    private static List<string> chessCoordsYAxisReverced = new List<string>() { "8", "7", "6", "5", "4", "3", "2", "1" };
    //Calculates places the queen can move on the X Axis
    public static List<string> possibleMovesXAxis(string location)
    {
        char[] XY = location.ToCharArray();
        List<string> possibleMoves = new List<string>();
        if (XY[0] == "A"[0])//If the first coordinate in the queens current location is A then:
        {
            for (int i = 0; i < chessBoardA.Count; i++)//For each of the coords in the chessboardA List:
            {
                if (chessBoardA[i][1] != XY[1])// If the coordinate in chessBoardA list is not the current possition of the queen then:
                {
                    possibleMoves.Add(chessBoardA[i]);// Add coordinate to possible moves list.
                }
            }
        }
        else if (XY[0] == "B"[0])
        {
            for (int i = 0; i < chessBoardB.Count; i++)
            {
                if (chessBoardB[i][1] != XY[1])
                {
                    possibleMoves.Add(chessBoardB[i]);
                }
            }
        }
        else if (XY[0] == "C"[0])
        {
            for (int i = 0; i < chessBoardC.Count; i++)
            {
                if (chessBoardC[i][1] != XY[1])
                {
                    possibleMoves.Add(chessBoardC[i]);
                }
            }
        }
        else if (XY[0] == "D"[0])
        {
            for (int i = 0; i < chessBoardD.Count; i++)
            {
                if (chessBoardD[i][1] != XY[1])
                {
                    possibleMoves.Add(chessBoardD[i]);
                }
            }
        }
        else if (XY[0] == "E"[0])
        {
            for (int i = 0; i < chessBoardE.Count; i++)
            {
                if (chessBoardE[i][1] != XY[1])
                {
                    possibleMoves.Add(chessBoardE[i]);
                }
            }
        }
        else if (XY[0] == "F"[0])
        {
            for (int i = 0; i < chessBoardF.Count; i++)
            {
                if (chessBoardF[i][1] != XY[1])
                {
                    possibleMoves.Add(chessBoardF[i]);
                }
            }
        }
        else if (XY[0] == "G"[0])
        {
            for (int i = 0; i < chessBoardG.Count; i++)
            {
                if (chessBoardG[i][1] != XY[1])
                {
                    possibleMoves.Add(chessBoardG[i]);
                }
            }
        }
        else if (XY[0] == "H"[0])
        {
            for (int i = 0; i < chessBoardH.Count; i++)
            {
                if (chessBoardH[i][1] != XY[1])
                {
                    possibleMoves.Add(chessBoardH[i]);
                }
            }
        }
        return possibleMoves;
    }
    //Calculates places the queen can move on the Y Axis (gets hole row on the Y Axis)
    public static List<string> possibleMovesYAxis(string location)
    {
        char[] XY = location.ToCharArray();
        List<string> possibleMoves = new List<string>();
        if (XY[1] == "1"[0])
        {
            for (int i = 0; i < chessBoard1.Count; i++)
            {
                if (chessBoard1[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard1[i]);
                }
            }
        }
        else if (XY[1] == "2"[0])
        {
            for (int i = 0; i < chessBoard2.Count; i++)
            {
                if (chessBoard2[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard2[i]);
                }
            }
        }
        else if (XY[1] == "3"[0])
        {
            for (int i = 0; i < chessBoard3.Count; i++)
            {
                if (chessBoard3[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard3[i]);
                }
            }
        }
        else if (XY[1] == "4"[0])
        {
            for (int i = 0; i < chessBoard4.Count; i++)
            {
                if (chessBoard4[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard4[i]);
                }
            }
        }
        else if (XY[1] == "5"[0])
        {
            for (int i = 0; i < chessBoard5.Count; i++)
            {
                if (chessBoard5[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard5[i]);
                }
            }
        }
        else if (XY[1] == "6"[0])
        {
            for (int i = 0; i < chessBoard6.Count; i++)
            {
                if (chessBoard6[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard6[i]);
                }
            }
        }
        else if (XY[1] == "7"[0])
        {
            for (int i = 0; i < chessBoard7.Count; i++)
            {
                if (chessBoard7[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard7[i]);
                }
            }
        }
        else if (XY[1] == "8"[0])
        {
            for (int i = 0; i < chessBoard8.Count; i++)
            {
                if (chessBoard8[i][0] != XY[0])
                {
                    possibleMoves.Add(chessBoard8[i]);
                }
            }
        }
        return possibleMoves;
    }

    //gets the index number of a given Y axis chess coord in the chessCoordsXAxis list
    static int placeInYAxis(string location)
    {
        for (int i = 0; i < chessCoordsYAxis.Count; i++)
        {
            if (location[1] == chessCoordsYAxis[i][0])
            {
                return i;
            }
        }
        return 0;
    }
    //gets the index number of a given X axis chess coord in the chessCoordsYAxis list
    static int placeInXAxis(string location)
    {
        for (int i = 0; i < chessCoordsXAxis.Count; i++)
        {
            if (location[0] == chessCoordsXAxis[i][0])
            {
                return i;
            }
        }
        return 0;
    }

    //gets the index number of a given Y axis chess coord in the chessCoordsYAxisReverced list
    static int placeInYAxisReverced(string location)
    {
        for (int i = 0; i < chessCoordsYAxisReverced.Count; i++)
        {
            if (location[1] == chessCoordsYAxisReverced[i][0])
            {
                return i;
            }
        }
        return 0;
    }
    //gets the index number of a given X axis chess coord in the chessCoordsXAxisReverced list
    static int placeInXAxisReverced(string location)
    {
        for (int i = 0; i < chessCoordsXAxisReverced.Count; i++)
        {
            if (location[0] == chessCoordsXAxisReverced[i][0])
            {
                return i;
            }
        }
        return 0;
    }

    //Calculates places the queen can move starting from the queens current position to top left diagonally 
    public static List<string> calcDiagonalTopLeft(string location)
    {
        List<string> coordinatesX = new List<string>();
        List<string> coordinatesY = new List<string>();

        List<string> coordinates = new List<string>();

        //Finds all the X coords I.E A,B,C,D
        for (int i = placeInXAxisReverced(location); i < chessCoordsXAxisReverced.Count; i++)
        {
            coordinatesX.Add(chessCoordsXAxisReverced[i]);
        }


        //Finds all the Y coords I.E 1,2,3,4
        for (int i = placeInYAxis(location); i < chessCoordsYAxis.Count; i++)
        {
            coordinatesY.Add(chessCoordsYAxis[i]);
        }

        //Prevents issue of having un-even arrays (coordinatesX, coordinatesY)
        int diffrenceX = coordinatesX.Count - coordinatesY.Count;
        if (coordinatesX.Count > coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceX; i++)
            {
                coordinatesX.RemoveAt(coordinatesX.Count - 1);//Remove last element
            }
        }
        int diffrenceY = coordinatesY.Count - coordinatesX.Count;
        if (coordinatesX.Count < coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceY; i++)
            {
                coordinatesY.RemoveAt(coordinatesY.Count - 1);//Remove last element
            }
        }
        coordinatesX.RemoveAt(0);
        coordinatesY.RemoveAt(0);
        //Adds both X and Y coords together to get a chess coord such as D1 or A5
        for (int i = 0; i < coordinatesX.Count; i++)
        {
            coordinates.Add(coordinatesX[i] + coordinatesY[i]);
        }

        return coordinates;
    }

    //Calculates places the queen can move starting from the queens current position to top right diagonally 
    public static List<string> calcDiagonalTopRight(string location)
    {
        List<string> coordinatesX = new List<string>();
        List<string> coordinatesY = new List<string>();

        List<string> coordinates = new List<string>();

        //Finds all the X coords I.E A,B,C,D
        for (int i = placeInXAxis(location); i < chessCoordsXAxis.Count; i++)
        {
            coordinatesX.Add(chessCoordsXAxis[i]);
        }
        //Finds all the Y coords I.E 1,2,3,4
        for (int i = placeInYAxis(location); i < chessCoordsYAxis.Count; i++)
        {

            coordinatesY.Add(chessCoordsYAxis[i]);
        }
        //Prevents issue of having un-even arrays (coordinatesX, coordinatesY)
        int diffrenceX = coordinatesX.Count - coordinatesY.Count;
        if (coordinatesX.Count > coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceX; i++)
            {
                coordinatesX.RemoveAt(coordinatesX.Count - 1);//Remove last element
            }
        }
        int diffrenceY = coordinatesY.Count - coordinatesX.Count;
        if (coordinatesX.Count < coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceY; i++)
            {
                coordinatesY.RemoveAt(coordinatesY.Count - 1);//Remove last element
            }
        }
        coordinatesX.RemoveAt(0);
        coordinatesY.RemoveAt(0);
        //Adds both X and Y coords together to get a chess coord such as D1 or A5
        for (int i = 0; i < coordinatesX.Count; i++)
        {
            coordinates.Add(coordinatesX[i] + coordinatesY[i]);
        }

        return coordinates;
    }
    //Calculates places the queen can move starting from the queens current position to bottom left diagonally
    public static List<string> calcDiagonalBottomLeft(string location)
    {
        List<string> coordinatesX = new List<string>();
        List<string> coordinatesY = new List<string>();

        List<string> coordinates = new List<string>();


        //Finds all the X coords I.E A,B,C,D
        for (int i = placeInXAxisReverced(location); i < chessCoordsXAxisReverced.Count; i++)
        {
            coordinatesX.Add(chessCoordsXAxisReverced[i]);
        }
        //Finds all the Y coords I.E 1,2,3,4
        for (int i = placeInYAxisReverced(location); i < chessCoordsYAxisReverced.Count; i++)
        {
            coordinatesY.Add(chessCoordsYAxisReverced[i]);
        }

        //Prevents issue of having un-even arrays (coordinatesX, coordinatesY)
        int diffrenceX = coordinatesX.Count - coordinatesY.Count;
        if (coordinatesX.Count > coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceX; i++)
            {
                coordinatesX.RemoveAt(coordinatesX.Count - 1);//Remove last element
            }
        }
        int diffrenceY = coordinatesY.Count - coordinatesX.Count;
        if (coordinatesX.Count < coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceY; i++)
            {
                coordinatesY.RemoveAt(coordinatesY.Count - 1);//Remove last element
            }
        }
        coordinatesX.RemoveAt(0);
        coordinatesY.RemoveAt(0);
        //Adds both X and Y coords together to get a chess coord such as D1 or A5
        for (int i = 0; i < coordinatesX.Count; i++)
        {
            coordinates.Add(coordinatesX[i] + coordinatesY[i]);
        }
        return coordinates;
    }
    //Calculates places the queen can move starting from the queens current position to bottom right diagonally
    public static List<string> calcDiagonalBottomRight(string location)
    {
        List<string> coordinatesX = new List<string>();
        List<string> coordinatesY = new List<string>();

        List<string> coordinates = new List<string>();


        //Finds all the X coords I.E A,B,C,D
        for (int i = placeInXAxis(location); i < chessCoordsXAxis.Count; i++)
        {
            coordinatesX.Add(chessCoordsXAxis[i]);
        }
        //Finds all the Y coords I.E 1,2,3,4
        for (int i = placeInYAxisReverced(location); i < chessCoordsYAxisReverced.Count; i++)
        {
            coordinatesY.Add(chessCoordsYAxisReverced[i]);
        }

        //Prevents issue of having un-even arrays (coordinatesX, coordinatesY)
        int diffrenceX = coordinatesX.Count - coordinatesY.Count;
        if (coordinatesX.Count > coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceX; i++)
            {
                coordinatesX.RemoveAt(coordinatesX.Count - 1);//Remove last element
            }
        }
        int diffrenceY = coordinatesY.Count - coordinatesX.Count;
        if (coordinatesX.Count < coordinatesY.Count)
        {
            for (int i = 0; i < diffrenceY; i++)
            {
                coordinatesY.RemoveAt(coordinatesY.Count - 1);//Remove last element
            }
        }

        coordinatesX.RemoveAt(0);
        coordinatesY.RemoveAt(0);

        //Adds both X and Y coords together to get a chess coord such as D1 or A5
        for (int i = 0; i < coordinatesX.Count; i++)
        {
            coordinates.Add(coordinatesX[i] + coordinatesY[i]);
        }
        
        return coordinates;
    }

    //Executes functions for finding possible moves then merges all generated data into one list and outputs.
    public static List<string> getPossibleMoves(string currentLocation)
    {
        List<string> output = new List<string>();

        //merges all lists
        output.AddRange(possibleMovesXAxis(currentLocation));
        output.AddRange(possibleMovesYAxis(currentLocation));
        output.AddRange(calcDiagonalTopLeft(currentLocation));
        output.AddRange(calcDiagonalTopRight(currentLocation));
        output.AddRange(calcDiagonalBottomLeft(currentLocation));
        output.AddRange(calcDiagonalBottomRight(currentLocation));
        return output;
    }

    //Debug Functions
    //======================================================================================
    public static void debugCalculateQueenMoves(string currentLocation)
    {
        Debug.Log("possibleMovesXAxis: " + string.Join(", ", possibleMovesXAxis(currentLocation)));
        Debug.Log("possibleMovesYAxis: " + string.Join(", ", possibleMovesYAxis(currentLocation)));
        Debug.Log("calcDiagonalTopLeft: " + string.Join(", ", calcDiagonalTopLeft(currentLocation)));
        Debug.Log("calcDiagonalTopRight: " + string.Join(", ", calcDiagonalTopRight(currentLocation)));
        Debug.Log("calcDiagonalBottomLeft: " + string.Join(", ", calcDiagonalBottomLeft(currentLocation)));
        Debug.Log("calcDiagonalBottomRight:" + string.Join(", ", calcDiagonalBottomRight(currentLocation)));
    }
}