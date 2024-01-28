using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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

    private void Update()
    {
        //textoEnemigo.text = "";
        

        //Button botonSeleccionado = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();

        //if (botonSeleccionado == boton1)
        //{
        //    textoJugador.text = "Chiste 1";
        //    seleccion = 1;
            
        //}
        //else if (botonSeleccionado == boton2)
        //{
        //    textoJugador.text = "Chiste 2";
        //    seleccion = 2;
            


        //}
        //else if (botonSeleccionado == boton3)
        //{
        //    textoJugador.text = "Chiste 3";
        //    seleccion = 3;

        //}

    }

    public void SelectButton(int seleccion)
    {
        if (seleccion == 1)
        {
            textoJugador.text = "Chiste 1";
            seleccion = 1;

        }
        else if (seleccion == 2)
        {
            textoJugador.text = "Chiste 2";
            seleccion = 2;

            print("Texto ganador");
            StartCoroutine(Victoria());
        }
        else if (seleccion == 3)
        {
            textoJugador.text = "Chiste 3";
            seleccion = 3;

        }
    }

    private IEnumerator Victoria()
    {
        print("Corrutina ganador");
        yield return new WaitForSeconds(3);
        print("Corrutina ganador22222");
        textoJugador.text = "Ganaste";
    }


    void Contador(int seleccion)
    {
        
    }
}
