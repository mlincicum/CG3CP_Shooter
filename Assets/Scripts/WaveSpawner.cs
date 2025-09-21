using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float startTime;
    [SerializeField] private float endTime;
    [SerializeField] private float spawnRate;

    void Start()
    {
        WaveManager.instance.AddWave(this);
        
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }

    void Spawn()
    {
        Instantiate(prefab,transform.position,transform.rotation);
    }

    void EndSpawner()
    {
        CancelInvoke();
        WaveManager.instance.RemoveWave(this);
    }
}
