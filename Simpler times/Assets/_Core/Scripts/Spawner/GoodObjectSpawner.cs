using System;
using UnityEngine;

public class GoodObjectSpawner : ObjectSpawner
{
    [SerializeField] private GameObject goodObjectToSpawn;
    [SerializeField] private float delay;

    private void Start()
    {
        StartCoroutine(SpawnObject(goodObjectToSpawn, delay));
    }
    
}
