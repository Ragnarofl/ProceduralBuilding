using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BuildingGenerator
{
    public static Building Generate(BuildingSettings settings)
    {
        //Generate a building based on the settings script
        return new Building(settings.Size.x, 
                            settings.Size.y, 
                            settings.wingsStrategy != null ? //If a strategy is given
                                settings.wingsStrategy.GenerateWings(settings) : //Use the strategy
                                ((WingsStrategy)ScriptableObject.CreateInstance<DefaultWingsStrategy>()).GenerateWings(settings) //Else use the default strategy for wings
                            );
    }
}
