using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RoofStrategy : ScriptableObject
{
    public abstract Roof GenerateRoof(BuildingSettings settings, RectInt bounds);
}
