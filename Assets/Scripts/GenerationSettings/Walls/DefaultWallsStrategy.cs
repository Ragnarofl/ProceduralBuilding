using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWallsStrategy : WallsStrategy
{
    public override Wall[] GenerateWalls(BuildingSettings settings, RectInt bounds, int level)
    {
        //Create the wall array
        Wall[] walls = new Wall[(bounds.size.x + bounds.size.y) * 2];
        int doorLocation = Random.Range(0, (bounds.size.x + bounds.size.y) * 2);

        //Randomly place one door on the first floor
        if (level == 1)
            walls[doorLocation] = Wall.Door;

        //Fill the rest of the building with windows with a random factor from 0 to 1 (100% chance)
        for (int i = 0; i < walls.Length; i++)
        {
            if (Random.Range(0, 101) < (settings.windowChance * 100) && walls[i] != Wall.Door)
            {
                walls[i] = Wall.Window;
            }
        }
        return walls;
    }
}
