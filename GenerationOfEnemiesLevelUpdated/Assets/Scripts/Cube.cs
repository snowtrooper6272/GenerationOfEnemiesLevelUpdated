using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 10;

    private float _lifeTime = 5;
    private float _currentLifeTime;

    public void SetDirection(Vector3 direction) 
    {
        _direction = direction;
    }

    private void Move() 
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
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
