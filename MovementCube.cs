using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCube : MonoBehaviour
{
    [SerializeField] private Transform _drivingDistance;
    [SerializeField] private Transform _currentPosition;
    [SerializeField] private Transform _passDistance;
    [SerializeField] private float _speed;

    private Vector3 _target;

    private int _index;
    private bool _moving = true;
    private float _distance;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.LookAt(_target);

        _target = _passDistance.position;

    transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (_moving)
        {
            if(_distance <= 0.05)
            {
               
            }
        }

    }
}
