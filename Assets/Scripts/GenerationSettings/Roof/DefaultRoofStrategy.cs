using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultRoofStrategy : RoofStrategy
{
    public override Roof GenerateRoof(BuildingSettings settings, RectInt bounds)
    {
        //Returns a random roof type
        return new Roof((RoofType)Random.Range(1, 4));
    }
}
