using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _specified;

    public Vector3 Specified => _specified;

    private void Start()
    {
        _specified = _specified.normalized;
    }
}
