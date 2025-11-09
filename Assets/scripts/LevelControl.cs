using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    private Dictionary<string, bool> isCompleted = new Dictionary<string, bool>()
    {
        {"AsteroidBelt", false},
        {"GrassPlanet", false},
        {"WaterPlanet", false},
        {"GlacierPlanet", false},
        {"SteamPlanet", false},
        {"FlamePlanet", false},
        {"LightningPlanet", false}
    };

    public void CompleteLevel(string levelName)
    {
        if (isCompleted.ContainsKey(levelName))
        {
            isCompleted[levelName] = true;
            Debug.Log($"{levelName} marked as completed.");
        }
        else
        {
            Debug.LogWarning($"Level {levelName} does not exist in the records.");
        }
    }

    public bool IsLevelCompleted(string levelName)
    {
        if (isCompleted.ContainsKey(levelName))
        {
            return isCompleted[levelName];
        }
        else
        {
            Debug.LogWarning($"Level {levelName} does not exist in the records.");
            return false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
