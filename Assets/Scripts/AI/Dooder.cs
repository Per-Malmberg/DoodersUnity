using System.Collections;
using UnityEngine;

public class Dooder : MonoBehaviour {
    private Vector3 _direction;
    [SerializeField]
    private float _speed = 10;

    private void Start() {
        InvokeRepeating("ChangeMoveDir", 5, 5);
    }

    private void ChangeMoveDir() {
        _direction = UnityEngine.Random.insideUnitCircle * _speed;
        _direction.y = 0;
    }

    private void Update() {
        Move();
    }

    private void Move() {
        transform.position += _direction * Time.deltaTime;
    }
}