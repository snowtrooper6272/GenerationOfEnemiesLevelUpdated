using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnpoints;
    [SerializeField] private Cube _prefab;
    [SerializeField] private float _interval;

    private float _currentTimeSpawn;

    private void Update()
    {
        if (_currentTimeSpawn > _interval) 
        {
            _currentTimeSpawn = 0;

            _spawnpoints[Random.Range(0, _spawnpoints.Length)].Spawn(_prefab);
        }

        _currentTimeSpawn += Time.deltaTime;
    }
}
