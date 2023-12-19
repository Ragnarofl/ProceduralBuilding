using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof
{
    RoofType type;
    RoofDirection direction;

    public RoofType Type { get => type; }
    public RoofDirection Direction { get => direction; }

    public Roof(RoofType type = RoofType.Peak, RoofDirection direction = RoofDirection.North)
    {
        this.type = type;
        this.direction = direction;
    }

    public override string ToString()
    {
        return "roof: " + type.ToString() + ((type == RoofType.Peak || type == RoofType.Slope) ? ", " + direction.ToString() : "");
    }
}

public enum RoofType
{
    Point,
    Peak,
    Slope,
    Flat
}

public enum RoofDirection
{
    North,
    East,
    West,
    South
}