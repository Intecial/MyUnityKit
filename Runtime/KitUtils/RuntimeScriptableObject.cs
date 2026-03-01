using System;
using System.Collections.Generic;
using UnityEngine;

namespace MyUnityKit.KitUtils {
    public abstract class RuntimeScriptableObject : ScriptableObject {
        public static List<RuntimeScriptableObject> Instances = new List<RuntimeScriptableObject>();

        void OnEnable() => Instances.Add(this);

        void OnDisable() => Instances.Remove(this);

        protected abstract void Reset();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void ResetAllInstances() {
            foreach (var instance in Instances) {
                instance.Reset();
            }
        }
    }
}