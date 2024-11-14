using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Cube _prefab;
    [SerializeField] private Vector3 _specified;

    private void Start()
    {
        _specified = _specified.normalized;
    }

    public void Spawn(Cube prefab) 
    {
        Cube CreatedCube = Instantiate(prefab, transform);

        CreatedCube.SetDirection(_specified);
    }
}
