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
        textoJugador.text = "Dialogo Jugador 1";
        textoEnemigo.text = "";
        contador = 1;
    }

    // Update is called once per frame
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
                textoEnemigo.text = "dialogo 1";
                break;
            case 2:
                textoJugador.text = "dialogo 2";
                break;
            case 3:
                textoEnemigo.text = "dialogo 3";
                break;
            case 4:
                textoJugador.text = "dialogo 4";
                break;
        }

        if(contador >= 4)
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
