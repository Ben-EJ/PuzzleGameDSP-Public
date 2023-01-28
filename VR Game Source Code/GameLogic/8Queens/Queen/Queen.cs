using System.Collections;
using System.Collections.Generic;

//Queens class stores information about each queen such as name, number, possible moves and current coordinates
public class Queen 
{
    int queenNumber = 0;
    string queenName = "";
    List<string> possibleMoves = new List<string>();
    public string queenXYChessCoords = "";

    public Queen(int queenNumberToSet, string queenNameToSet, List<string> possibleMovesToSet, string queenXYChessCoordsSet)
    {
        queenNumber = queenNumberToSet;
        queenName = queenNameToSet;
        possibleMoves = possibleMovesToSet;
        queenXYChessCoords = queenXYChessCoordsSet;
    }
    //Gets the queens number
    public int getQueenNumber()
    {
        return queenNumber;
    }
    //Sets the queens number
    public void setQueenNumber(int queenNumberToSet)
    {
        queenNumber = queenNumberToSet;
    }
    //Gets the queens name
    public string getQueenName()
    {
        return queenName;
    }
    //Sets the queens name
    public void setQueenName(string queenNameToSet)
    {
        queenName = queenNameToSet;
    }
    //Gets a queens possible moves
    public List<string> getPossibleMoves()
    {
        return possibleMoves;
    }
    //Sets a queens possible moves
    public void setPossibleMoves(List<string> possibleMovesToSet)
    {
        possibleMoves = possibleMovesToSet;
    }
    //Gets a queens X and Y Coordinates
    public string getQueenXYChessCoords()
    {
        return queenXYChessCoords;
    }
    //Sets a queens X and Y Coordinates
    public void setQueenXYChessCoords(string queenXYChessCoordsSet)
    {
        queenXYChessCoords = queenXYChessCoordsSet;
    }
}