using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogos : MonoBehaviour
{
    public Text textoJugador;
    public Text textoEnemigo;

    public GameObject panel;
    public GameObject chistes;
    private int contador;

   // [SerializeField] Button btnAtaque1;



    void Start()
    {
        chistes.SetActive(false);
        textoJugador.text = "Disculpame, \n ¿sabes cómo arreglar una nave espacial?";
        textoEnemigo.text = "";
        contador = 1;
    }
 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            Dialogar();
            contador++;
        }
        
    }

    void Dialogar()
    {
        

        switch (contador)
        {
            case 1:
                textoJugador.text = "Colisioné aquí por defecto del sistema.";
                break;
            case 2:
                textoEnemigo.text = "Sí, obvio, por eso traigo mi corbata puesta";
                break;
            case 3:
                textoJugador.text = "¡Oh! ¿Es la nueva moda de los mecánicos?";
                break;
            case 4:
                textoEnemigo.text = "*Se ríe*";
                break;
            case 5:
                textoEnemigo.text = "¿Se te rompió el coche en plenas vacaciones?";
                break;
        }

        if(contador >= 5)
        {
            ContarChiste();
        }
        
    }

    public void ContarChiste()
    {

        textoJugador.text = "...";
        chistes.SetActive(true);


    } 
}
