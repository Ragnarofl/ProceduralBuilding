using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing
{
    RectInt bounds;
    Story[] stories;
    Roof roof;

    public RectInt Bounds { get => bounds; }
    public Story[] Stories { get => stories; }
    public Roof Roof { get => roof; }

    public Wing(RectInt bounds)
    {
        this.bounds = bounds;
    }
    public Wing(RectInt bounds, Story[] stories, Roof roof)
    {
        this.bounds = bounds;
        this.stories = stories;
        this.roof = roof;
    }

    public override string ToString()
    {
        string wing = "wing(" + bounds.ToString() + "):\n";
        foreach (Story story in stories)
        {
            wing += "\t" + story.ToString() + "\n";
        }
        wing += "\t" + roof.ToString() + "\n";
        return wing;
    }
}
