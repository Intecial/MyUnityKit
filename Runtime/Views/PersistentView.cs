using UnityEngine;
using UnityEngine.UIElements;

namespace MyUnityKit.Views {
    public class PersistentView : MonoBehaviour {
        protected VisualElement UI;

        protected virtual void OnEnable() {
            ModalView.OnShow += Hide;
            ModalView.OnHide += Show;
        }

        protected virtual void OnDisable() {
            ModalView.OnShow -= Hide;
            ModalView.OnHide -= Show;
        }

        private void OnDestroy() {
            ModalView.OnShow -= Hide;
            ModalView.OnHide -= Show;
        }

        protected virtual void Awake() {
            UI = GetComponent<UIDocument>().rootVisualElement;
        }

        protected void Hide() {
            UI.style.display = DisplayStyle.None;
        }

        protected void Show() {
            UI.style.display = DisplayStyle.Flex;
        }
    }
}