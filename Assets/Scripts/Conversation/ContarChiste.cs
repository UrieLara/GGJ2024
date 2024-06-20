using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContarChiste : MonoBehaviour
{
    public Text textoJugador;
    public Text textoEnemigo;

    [SerializeField] Button boton1;
    [SerializeField] Button boton2;
    [SerializeField] Button boton3;
    //public GameObject panel;

    private int seleccion = 0;
    private int[] contador = new int[3];

    public string victoria = "";

    private void Update()
    {
     

    }

    public void SelectButton(int seleccion)
    {
        if (seleccion == 1)
        {
            // textoJugador.text = "Sí, se rompió en la caída.";
            StartCoroutine(Derrota());
        }
        else if (seleccion == 2)
        {
           // textoJugador.text = "No, solo le faltan un par de tornillos.";
            StartCoroutine(Victoria());
        }
        else if (seleccion == 3)
        {
            // textoJugador.text = "No, solo está tomando un descanso.";
            StartCoroutine(Derrota());
        }

        boton1.enabled = false;
        boton2.enabled = false;
        boton3.enabled = false;
    }

    private IEnumerator Victoria()
    {
        
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Victoria");
      
    }

    private IEnumerator Derrota()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Derrota");
        
    }


 
}
