using System;
using UnityEngine;

namespace KristinaWaldt.Examples
{
    public class OpenCloseWhenMenu : MonoBehaviour
    {
        private OpenableTweenBase tween;
        
        private void OnEnable()
        {
            Initialise();
            ToggleMenuButton.MenuStateChanged += OnMenuStateChanged;
        }

        private void OnDisable()
        {
            ToggleMenuButton.MenuStateChanged -= OnMenuStateChanged;
        }
        
        private void Initialise()
        {
            if (tween != null)
                return;
            
            tween = GetComponent<OpenableTweenBase>();
        }

        private void OnMenuStateChanged(bool value)
        {
            if (tween == null)
                return;
            
            // TODO: Add OpenUsingState to Base
            if (value)
            {
                tween.Open();
            }
            else
            {
                tween.Close();
            }
        }
    }
}