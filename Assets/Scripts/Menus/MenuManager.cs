using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager sharedInstance;

    public Canvas menuMainCanvas, menuCreditsCanvas;


    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    private void Start()
    {
        menuMainCanvas.enabled = true;
        menuCreditsCanvas.enabled = false;
    }

  

    public void ToggleMainMenu(bool show)
    {
        menuMainCanvas.enabled = show;
    }

    public void ToggleCreditsMenu(bool show)
    {
        menuCreditsCanvas.enabled = show;
    }

  

}
