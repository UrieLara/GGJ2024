using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    [SerializeField] CanvasGroup canvasGroup;


    [SerializeField] bool fadeIn = false;
    [SerializeField] bool fadeOut = false;


    void Start()
    {
        
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
                }
            }
        }

        if (fadeOut)
        {
            if (canvasGroup.alpha >= 1)
            {
                canvasGroup.alpha -= Time.deltaTime;

                if (canvasGroup.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }

    }



    public void ShowUI(Canvas canvas)
    {
        fadeIn = true;
    }

    public void HideUI(Canvas canvas)
    {
        fadeOut = true;
    }
}
