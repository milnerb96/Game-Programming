using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{

    public Dropdown carSpeed;
    public Dropdown carSpawn;
    public Dropdown froggerSelection;
    public Dropdown carSizeSelection;

    void Update()
    {
        if (carSpeed.value == 0) {
            SpeedEasySelection();
        }

        if (carSpeed.value == 1)
        {
            SpeedIntermediateSelection();
        }

        if (carSpeed.value == 2)
        {
            SpeedHardSelection();
        }

        if (carSpawn.value == 0)
        {
            SpawnEasySelection();
        }

        if (carSpawn.value == 1)
        {
            SpawnIntermediateSelection();
        }

        if (carSpawn.value == 2)
        {
            SpawnHardSelection();
        }

        if (froggerSelection.value == 0)
        {
            Frog.scale = .5f;
        }

        if (froggerSelection.value == 1)
        {
            Frog.scale = .75f;
        }

        if (froggerSelection.value == 2)
        {
            Frog.scale = 1.5f;
        }

        if (carSizeSelection.value == 0)
        {
            CarSpawner.scale = .5f;
        }

        if (carSizeSelection.value == 1)
        {
            CarSpawner.scale = .75f;
        }

        if (carSizeSelection.value == 2)
        {
            CarSpawner.scale = 1.5f;
        }
    }
   

    void SpeedEasySelection()
    {
        Car.minSpeed = 4f;
        Car.maxSpeed = 8f;
    }

    void SpeedIntermediateSelection()
    {
        Car.minSpeed = 8f;
        Car.maxSpeed = 12f;
    }

    void SpeedHardSelection()
    {
        Car.minSpeed = 12f;
        Car.maxSpeed = 16f;
    }
    

    void SpawnEasySelection()
    {
        CarSpawner.spawnDelay = .6f;
    }

    void SpawnIntermediateSelection()
    {
        CarSpawner.spawnDelay = .4f;
    }

    void SpawnHardSelection()
    {
        CarSpawner.spawnDelay = .3f;
    }
}

