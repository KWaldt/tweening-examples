using System;
using UnityEngine;
using UnityEngine.UI;

public class OpenMenuButton : MonoBehaviour
{
    private Button button;

    private bool isMenuOpen = true; // default: false

    public static event Action OpenMenu;
    public static event Action CloseMenu;
    public static event Action<bool> ChangeMenu;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        // !: invertiert bool
        isMenuOpen = !isMenuOpen;
        
        ChangeMenu?.Invoke(isMenuOpen);
        
        // if (isMenuOpen == true)
        // {
        //     isMenuOpen = false;
        // }
        // else
        // {
        //     isMenuOpen = true;
        // }

        // isMenuOpen == true
        // if (isMenuOpen) {}
        
        // isMenuOpen == false
        // if(!isMenuOpen) {}
    }
}
