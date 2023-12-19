using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultStoriesStrategy : StoriesStrategy
{
    public override Story[] GenerateStories(BuildingSettings settings, RectInt bounds, int nbrStories)
    {
        //Fills the arrays with the nomber of stories determined before
        Story[] stories = new Story[nbrStories];
        for (int i = 0; i < nbrStories; i++)
        {
            stories[i] = settings.storyStrategy != null ?
                                settings.storyStrategy.GenerateStory(settings, bounds, i) :
                                ((StoryStrategy)ScriptableObject.CreateInstance<DefaultStoryStrategy>()).GenerateStory(settings, bounds, i);
        }
        return stories;
    }
}
