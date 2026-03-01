using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace MyUnityKit.Views {
    public class ModalView : MonoBehaviour {
        protected VisualElement UI;
        public static event Action OnShow;

        public static event Action OnHide;

        protected virtual void Awake() {
            UI = GetComponent<UIDocument>().rootVisualElement;
        }

        protected virtual void Start() {
            Hide();
        }


        protected void Hide() {
            OnHide?.Invoke();
            UI.style.display = DisplayStyle.None;
        }

        protected void Show() {
            OnShow?.Invoke();
            UI.style.display = DisplayStyle.Flex;
        }
    }
}