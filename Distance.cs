using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private List<Transform> _runners;
    [SerializeField] private float _speed;

    private int _currentIndex;
    private int _targetIndex;

    private void Start()
    {
        _targetIndex = _currentIndex + 1;
    }

    private void Update()
    {
        Transform _currentRunner = _runners[_currentIndex];
        Transform _targetRunner = _runners[_targetIndex];

        _currentRunner.LookAt(_targetRunner.position);

        _currentRunner.position = Vector3.MoveTowards(_currentRunner.position, _targetRunner.position, _speed * Time.deltaTime);

        if (_currentRunner.position == _targetRunner.position)
        {
            _currentIndex = _targetIndex;
            _currentRunner.LookAt(_targetRunner.position);

            if (_targetIndex < _runners.Count - 1)
            {
                _targetIndex++;
            }
            else
            {
                _targetIndex = 0;
            }
        }
    }
}
