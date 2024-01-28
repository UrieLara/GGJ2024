using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Renderer rendererObject;

    public Color defaultColor;
    public Color newColor;

    public bool colorChanged;

    private void Start()
    {
       
    }

    private void Update()
    {

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void ChangeColorMetho(Color colorToChange)
    {
        colorChanged = !colorChanged;   
        
        rendererObject.material.color = colorToChange;  

    }
}

