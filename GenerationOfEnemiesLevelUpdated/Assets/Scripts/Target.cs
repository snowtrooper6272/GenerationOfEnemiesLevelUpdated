using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _controlPoints;
    [SerializeField] private int _speed;

    private Transform _currentTargetPoint;
    private int _currentIndexOfPoint;

    private void Start()
    {
        _currentTargetPoint = _controlPoints[0];
    }

    private void Update()
    {
        if (transform.position == _currentTargetPoint.position) 
            SwitchControlPoint();

        transform.position = Vector3.MoveTowards(transform.position, _currentTargetPoint.position, Time.deltaTime * _speed);
    }

    public void SwitchControlPoint() 
    {
        if (_currentIndexOfPoint == _controlPoints.Length - 1)
            _currentIndexOfPoint = 0;
        else 
            _currentIndexOfPoint++;

        _currentTargetPoint = _controlPoints[_currentIndexOfPoint];
    }
}
