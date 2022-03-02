using System;
using UnityEngine;
using UnityEngine.UI;

namespace KristinaWaldt.Examples
{
    [RequireComponent(typeof(Button))]
    public class ToggleMenuButton : MonoBehaviour
    {
        private Button button;
        private bool menuState = true;

        public static event Action<bool> MenuStateChanged;

        private void OnEnable()
        {
            if (button == null)
            {           
                button = GetComponent<Button>();
            }
            button.onClick.AddListener(Toggle);
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(Toggle);
        }

        private void Toggle()
        {
            menuState = !menuState;
            MenuStateChanged?.Invoke(menuState);
        }
    }
}