using System;
using UnityEngine;

public class PlayAnimationOnMenu : MonoBehaviour
{
    // TODO: Support multiple animations
    private OpenCloseTweenBase[] animations;

    private void Awake()
    {
        animations = GetComponents<OpenCloseTweenBase>();
    }

    private void OnEnable()
    {
        OpenMenuButton.ChangeMenu += OnChangeMenu;
    }
    
    private void OnDisable()
    {
        // -=
        OpenMenuButton.ChangeMenu -= OnChangeMenu;
    }
    
    private void OnChangeMenu(bool isMenuOpen)
    {
        if (isMenuOpen)
        {
            foreach (var anim in animations)
            {
                anim.Open();
            }
        }
        else
        {
            foreach (var anim in animations)
            {
                anim.Close();
            }
        }
    }
}