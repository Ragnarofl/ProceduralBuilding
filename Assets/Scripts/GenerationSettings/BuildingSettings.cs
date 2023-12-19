using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Building Generation/Building Settings")]
public class BuildingSettings : ScriptableObject
{
    //Various settings for all buildings, accessible everywhere
    public Vector2Int buildingSize;
    public Vector2Int Size { get { return buildingSize; } }
    public int minimumHeight = 1;
    public int maximumHeight = 1;
    public int doorCount;
    public float windowChance;
    public WingsStrategy wingsStrategy;
    public WingStrategy wingStrategy;
    public StoriesStrategy storiesStrategy;
    public StoryStrategy storyStrategy;
    public WallsStrategy wallStrategy;
    public RoofStrategy roofStrategy;
}
