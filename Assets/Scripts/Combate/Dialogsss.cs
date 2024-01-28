using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public GameObject panel;
    public GameObject chistes;

    public string[] SdialogoJugador;
    public string[] SdialogoEnemigo;
    public string[] SdialogoChiste;

    public Text txtDialogo;

    public bool isDialogActive;

    Coroutine auxCorutine;

    int veces = 0;

    public void AbrirCajaDialogo(int valor)
    {
        if (isDialogActive)
        {
            CerrarDialogo();
            StartCoroutine(espera(valor));

        }
        else
        {
            isDialogActive = false;
            auxCorutine = StartCoroutine(mostrarDialogo(valor));
        }
    }

    IEnumerator mostrarDialogo(int valor, float time = 0.1f)
    {
        panel.SetActive(true);
        string[] dialogo;

        if (valor == 0) { dialogo = SdialogoJugador; }
        else if(valor == 1) { dialogo = SdialogoEnemigo; }
        else { dialogo = SdialogoChiste; }

        int total = dialogo.Length;
        string res = "";
        isDialogActive = true;


        yield return null;

        for(int i = 0; i<total; i++)
        {
            res = "";
            if (isDialogActive)
            {
                for (int s = 0; s < dialogo[i].Length; s++)
                {
                    if (isDialogActive)
                    {
                        res = string.Concat(res, dialogo[i][s]);
                        txtDialogo.text = res;
                        yield return new WaitForSeconds(time);
                    }
                    else yield break;

                }
                yield return new WaitForSeconds(0.4f);
            }
            else yield break;

        }
        yield return new WaitForSeconds(0.4f);
        Debug.Log("cerramos");
        CerrarDialogo();
    }

    IEnumerator espera(int valor)
    {
        yield return new WaitForEndOfFrame();
        auxCorutine = StartCoroutine(mostrarDialogo(valor));
    }

    public void CerrarDialogo()
    {
        isDialogActive = false;
        if(auxCorutine != null)
        {
            Debug.Log("deteniendo");
            StopCoroutine(auxCorutine);
            auxCorutine = null;
        }

        txtDialogo.text = "";
       // panel.SetActive(false);
    }

    private void Start()
    {
        chistes.SetActive(false);

    }
    private void Update()
    {
        //   txtDialogoEnemigo.gameObject.SetActive(false);

        AbrirCajaDialogo(0);
        if (Input.GetKeyDown(KeyCode.A) && !isDialogActive)
        {
            veces++;
        }

        switch (veces) {
            case 0:
                AbrirCajaDialogo(0);
                break;
            case 1:
                AbrirCajaDialogo(1);

                break;
            case 2:

                break;
        }
    }
}
