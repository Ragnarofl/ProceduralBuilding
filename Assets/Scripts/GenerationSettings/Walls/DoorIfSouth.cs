using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Building Generation/Walls/Door If South")]
public class DoorIfSouth : WallsStrategy
{
    public override Wall[] GenerateWalls(BuildingSettings settings, RectInt bounds, int level)
    {
        Wall[] walls = new Wall[(bounds.size.x + bounds.size.y) * 2];
        int doorLocation = Random.Range(0, bounds.max.x);
        Debug.Log(doorLocation);

        for (int x = bounds.min.x; x < bounds.max.x; x++)
        {
            for (int y = bounds.min.y; y < bounds.max.y; y++)
            {
                //south wall
                if (y == bounds.min.y && level == 1)
                {
                    if (x == doorLocation)
                        walls[x - bounds.min.x] = Wall.Door;
                }
                if (Random.Range(0, 101) < (settings.windowChance * 100) && walls[y + (x * y)] != Wall.Door)
                {
                    walls[y + (x * y)] = Wall.Window;
                }
            }
        }

        return walls;
    }
}
