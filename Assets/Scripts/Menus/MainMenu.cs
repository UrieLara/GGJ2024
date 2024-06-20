using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public void ShowCredits()
    {
        MenuManager.sharedInstance.ToggleCreditsMenu(true);
        MenuManager.sharedInstance.ToggleMainMenu(false);
    }

    public void ReturnMainMenu()
    {
        MenuManager.sharedInstance.ToggleCreditsMenu(false);
        MenuManager.sharedInstance.ToggleMainMenu(true);
    }

}
