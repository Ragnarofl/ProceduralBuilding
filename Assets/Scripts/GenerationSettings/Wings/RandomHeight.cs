using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Building Generation/Wings/Random Height")]
public class RandomHeight : WingsStrategy
{
    public override Wing[] GenerateWings(BuildingSettings settings)
    {
        int nbrStories = Random.Range(settings.minimumHeight, settings.maximumHeight + 1);
        return new Wing[] {
            settings.wingStrategy != null ?
                settings.wingStrategy.GenerateWing(settings, new RectInt(0, 0, settings.Size.x, settings.Size.y), nbrStories) :
                ((WingStrategy)ScriptableObject.CreateInstance<DefaultWingStrategy>()).GenerateWing(settings, new RectInt(0, 0, settings.Size.x, settings.Size.y), nbrStories)
        };
    }
}
