using System;
using System.Collections;
using UnityEngine;

namespace Environment {
    public class FoodSpawner : MonoBehaviour {
        [SerializeField] private int _min, _max;
        [SerializeField] private GameObject _food;

        private void Start() {
            Invoke("SpawnFood", UnityEngine.Random.Range(_min, _max));
        }

        private void SpawnFood() {
            Instantiate(_food, new Vector3(UnityEngine.Random.Range(-50, 50), 0, UnityEngine.Random.Range(-50, 50)), Quaternion.identity);
            Invoke("SpawnFood", UnityEngine.Random.Range(_min, _max));
        }
    }
}