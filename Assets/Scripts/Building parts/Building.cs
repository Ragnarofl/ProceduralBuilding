using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building
{
    //Definition of the main class Building
    Vector2Int size;
    Wing[] wings;

    public Vector2Int Size { get { return size; } }
    public Wing[] Wings { get { return wings; } }

    public Building(int sizeX, int sizeY, Wing[] wings)
    {
        size = new Vector2Int(sizeX, sizeY);
        this.wings = wings;
    }

    //Override of ToString to print the building composition for debug purpose
    public override string ToString()
    {
        string building = "building:(" + size.ToString() + "; " + wings.Length + ")\n";
        foreach(Wing w in wings)
        {
            building += "\t" + w.ToString() + "\n";
        }
        return building;
    }
}
