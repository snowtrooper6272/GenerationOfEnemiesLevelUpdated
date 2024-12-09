using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private int _speed;

    private Transform _target;

    private float _lifeTime = 5;
    private float _currentLifeTime;

    public void SetTarget(Transform target) 
    {
        _target = target;
    }

    private void Move() 
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
    
    private void Update()
    {
        Move();

        if (_lifeTime <= _currentLifeTime) 
        {
            Destroy(gameObject);
        }

        _currentLifeTime += Time.deltaTime;
    }
}
