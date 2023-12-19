using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWingsStrategy : WingsStrategy
{
    public override Wing[] GenerateWings(BuildingSettings settings)
    {
        //Fill the wing array, a <Wings> can give either <Wing> or <Wing> <Wings> to always give a different total number of wings
        //In the default strategy only one wing is create
        return new Wing[] {
            settings.wingStrategy != null ?
                settings.wingStrategy.GenerateWing(settings, new RectInt(0, 0, settings.Size.x, settings.Size.y), settings.maximumHeight) :
                ((WingStrategy)ScriptableObject.CreateInstance<DefaultWingStrategy>()).GenerateWing(settings, new RectInt(0, 0, settings.Size.x, settings.Size.y), settings.maximumHeight)
        };
    }
}
