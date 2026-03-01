using System;
using UnityEngine;


namespace MyUnityKit.KitUtils {
    public class TimeManager {
        public float time;

        public float countdown;
        public event Action OnTimerEnd;

        public bool IsRepeatable = false;
        public bool isStarted = false;

        public TimeManager(float time) {
            this.time = time;
            countdown = time;
        }

        public void StartTimer() {
            isStarted = true;
        }

        public void StopTimer() {
            isStarted = false;
        }

        public void ResetTimer() {
            isStarted = false;
            countdown = time;
        }

        public void Tick() {
            if (!isStarted) return;
            countdown -= Time.deltaTime;
            if (countdown <= 0f) {
                if (IsRepeatable) countdown = time;
                OnTimerEnd?.Invoke();
            }
        }
    }
}