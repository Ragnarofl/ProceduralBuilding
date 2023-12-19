using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultStoryStrategy : StoryStrategy
{
    public override Story GenerateStory(BuildingSettings settings, RectInt bounds, int level)
    {
        //Fill the story with walls, there isn't much to be done in term of strategy here for now
        return new Story(level,
                        settings.wallStrategy != null ?
                            settings.wallStrategy.GenerateWalls(settings, bounds, level + 1) :
                            ((WallsStrategy)ScriptableObject.CreateInstance<DefaultWallsStrategy>()).GenerateWalls(settings, bounds, level + 1)
                        );
    }
}
