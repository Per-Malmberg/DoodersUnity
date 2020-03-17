using System;
using Environment;
using UnityEngine;

namespace Senses {
    public class Sight : MonoBehaviour {
        internal Food CurrentTarget { get; set; }

        [SerializeField] private float _distance = 50;
        [SerializeField] private float _viewAngle = 45;

        private void Update() {
            if (CurrentTarget == null) {
                return;
            }
            var forward = gameObject.transform.forward;
            var foodz = FindObjectsOfType<Food>();
            foreach (var food in foodz) {
                if (Vector3.Distance(gameObject.transform.position, food.transform.position) > _distance) {
                    continue;
                }
                var foodDir = food.transform.position - gameObject.transform.position;
                if (Vector3.Angle(forward, foodDir) > _viewAngle / 2f) {
                    continue;
                }
                CurrentTarget = food;
            }
        }
    }
}