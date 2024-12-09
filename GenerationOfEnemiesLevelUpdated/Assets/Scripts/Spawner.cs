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
            SpawnPoint selectedSpawnpoint = _spawnpoints[Random.Range(0, _spawnpoints.Length)];
            _currentTimeSpawn = 0;

            Spawn(selectedSpawnpoint);
        }

        _currentTimeSpawn += Time.deltaTime;
    }

    public void Spawn(SpawnPoint spawnpoint)
    {
        Cube CreatedCube = Instantiate(_prefab, spawnpoint.transform);

        CreatedCube.SetTarget(spawnpoint.Target);
    }
}
