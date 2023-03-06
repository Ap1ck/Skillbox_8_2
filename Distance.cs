using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private List<Transform> _allPointList;
    [SerializeField] private float _speed;

    private Vector3 _target;
    private int _index = 0;
    private float _distance;
    private bool _moving;

    private void Update()
    {
        transform.Rotate(0, 0, 1);
        transform.LookAt(_target);
        _target = _allPointList[_index].transform.position;

        if (_moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        }

        _distance = Vector3.Distance(transform.position, _target);

        if (_distance <= 0.05f)
        {
            if (_allPointList[_index])
            {
                if (_allPointList[_index].position == _target)
                {
                    _target = _allPointList[_index].position;
                }
            }
        }
    }
}
