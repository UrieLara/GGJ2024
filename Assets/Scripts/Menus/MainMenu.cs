using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{

    AudioSource soundButton;

    private void Start()
    {
        soundButton = GetComponent<AudioSource>();
    }
    public void ShowCredits()
    {
        MenuManager.sharedInstance.ToggleCreditsMenu(true);
        MenuManager.sharedInstance.ToggleMainMenu(false);
        soundButton.Play();
    }

    public void ReturnMainMenu()
    {
        MenuManager.sharedInstance.ToggleCreditsMenu(false);
        MenuManager.sharedInstance.ToggleMainMenu(true);
        soundButton.Play();
    }

}
