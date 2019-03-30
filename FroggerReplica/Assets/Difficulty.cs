using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public Button easy;
    public Button intermediate;
    public Button hard;


    void Start()
    {
        easy.onClick.AddListener(EasySelection);
        intermediate.onClick.AddListener(IntermediateSelection);
        hard.onClick.AddListener(HardSelection);
    }
   

    void EasySelection()
    {
        Car.minSpeed = 4f;
        Car.maxSpeed = 8f;
        CarSpawner.spawnDelay = .6f;
    }

    void IntermediateSelection()
    {
        Car.minSpeed = 8f;
        Car.maxSpeed = 12f;
        CarSpawner.spawnDelay = .4f;
    }

    void HardSelection()
    {
        Car.minSpeed = 12f;
        Car.maxSpeed = 16f;
        CarSpawner.spawnDelay = .3f;
    }
}

