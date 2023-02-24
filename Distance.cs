using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private List<Transform> _allPoints;
    [SerializeField] private Transform _passDistance;
    [SerializeField] private float _speed;

    private bool _moving = true;

    private Vector3 _target;
    private int _index = 0;

    private void Update()
    {
        transform.Rotate(0, 0, 1);
        transform.LookAt(_target);
        _target = _passDistance.position;

        if (_allPoints[_index].position==_passDistance.position)
        {
            if (_moving)
            {
                transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
                transform.LookAt(_allPoints[_index].position);
            }
        }
        else
        {
            _index++;
        }

    }
}
