using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    public static Fade sharedInstance;
    public GameObject panel;

    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] bool fadeIn = false;
    [SerializeField] bool fadeOut = false;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    private void Start()
    {
        panel.SetActive(true);
        HideUI();
    }

    // Update is called once per frame
    private void Update()
    {
        if (fadeIn)
        {
            if (canvasGroup.alpha < 1)
            {
                canvasGroup.alpha += Time.deltaTime;

                if (canvasGroup.alpha >= 1)
                {
                    fadeIn = false;
                    panel.SetActive(false);
                }
            }
        }

        if (fadeOut)
        {
            if (canvasGroup.alpha >= 0)
            {
                canvasGroup.alpha -= Time.deltaTime;

                if (canvasGroup.alpha == 0)
                {
                    fadeOut = false;
                    panel.SetActive(false);
                }
            }
        }

    }



    public void ShowUI()
    { //aparecer = 1
        fadeIn = true;
    }

    public void HideUI()
    {//desaparecer = 0
        fadeOut = true;
    }
}
