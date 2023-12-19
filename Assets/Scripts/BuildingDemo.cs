using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingDemo : MonoBehaviour
{
    public BuildingSettings settings;
    // Start is called before the first frame update
    void Start()
    {
        Building b = BuildingGenerator.Generate(settings); //Generate the building object
        GetComponent<BuildingRenderer>().Render(b); //Render the building
        Debug.Log(b.ToString()); //Print the building composition for debug
    }
}
