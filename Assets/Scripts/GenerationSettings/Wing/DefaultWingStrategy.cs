using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWingStrategy : WingStrategy
{
    public override Wing GenerateWing(BuildingSettings settings, RectInt bounds, int nbrStories)
    {
        //Fill the wing with Stories and a Roof, it behaves just like <Wings> to make the total number of stories change
        //In the default strategy the number nomber is always the maximum specified in settings
        return new Wing(bounds,
                        settings.storiesStrategy != null ?
                            settings.storiesStrategy.GenerateStories(settings, bounds, nbrStories) :
                            ((StoriesStrategy)ScriptableObject.CreateInstance<DefaultStoriesStrategy>()).GenerateStories(settings, bounds, nbrStories),
                        settings.roofStrategy != null ?
                            settings.roofStrategy.GenerateRoof(settings, bounds) :
                            ((RoofStrategy)ScriptableObject.CreateInstance<DefaultRoofStrategy>()).GenerateRoof(settings, bounds)
                        );
    }
}
