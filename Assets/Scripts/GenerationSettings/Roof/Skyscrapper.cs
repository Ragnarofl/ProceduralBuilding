using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Building Generation/Roof/Skyscrapper")]
public class Skyscrapper : RoofStrategy
{
    public override Roof GenerateRoof(BuildingSettings settings, RectInt bounds)
    {
        return new Roof(RoofType.Flat);
    }
}
