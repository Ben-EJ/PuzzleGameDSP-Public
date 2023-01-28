using System.Collections;
using System.Collections.Generic;

//Contains lists of all columns, rows and positions in grid.
public class Grid
{
    public List<string> gridWhole = new List<string>() { "location1", "location2", "location3", "location4", "location5", "location6",
    "location7", "location8", "location9","location10", "location11", "location12","location13", "location14", "location15","location16"};

    public List<string> gridLineUpOne = new List<string>() { "location1", "location5", "location9", "location13" };
    public List<string> gridLineUpTwo = new List<string>() { "location2", "location6", "location10", "location14" };
    public List<string> gridLineUpThree = new List<string>() { "location3", "location7", "location11", "location15" };
    public List<string> gridLineUpFour = new List<string>() { "location4", "location8", "location12", "location16" };

    public List<string> gridLineDownOne = new List<string>() { "location13", "location9", "location5", "location1" } ;
    public List<string> gridLineDownTwo = new List<string>() { "location14", "location10", "location6", "location2" };
    public List<string> gridLineDownThree = new List<string>() { "location15", "location11", "location7", "location3" };
    public List<string> gridLineDownFour = new List<string>() { "location16", "location12", "location8", "location4" };

    public List<string> gridLineRightOne = new List<string>() { "location4", "location3", "location2", "location1"};
    public List<string> gridLineRightTwo = new List<string>() { "location8", "location7", "location6", "location5"};
    public List<string> gridLineRightThree = new List<string>() { "location12", "location11", "location10", "location9"};
    public List<string> gridLineRightFour = new List<string>() { "location16", "location15", "location14", "location13"};

    public List<string> gridLineLeftOne = new List<string>() { "location1", "location2", "location3", "location4" };
    public List<string> gridLineLeftTwo = new List<string>() { "location5", "location6", "location7", "location8" };
    public List<string> gridLineLeftThree = new List<string>() { "location9", "location10", "location11", "location12" };
    public List<string> gridLineLeftFour = new List<string>() { "location13", "location14", "location15", "location16" };

}
