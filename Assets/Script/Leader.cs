using UnityEngine;

public class Leader : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _speed;

    private int _currentWayPoint = 0;

    private void Update()
    {
        transform.LookAt(_wayPoints[_currentWayPoint].position); 
        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWayPoint].position, _speed * Time.deltaTime);

        if(transform.position == _wayPoints[_currentWayPoint].position)
        {
            _currentWayPoint = (_currentWayPoint + 1) % _wayPoints.Length;
        }
    }
}   