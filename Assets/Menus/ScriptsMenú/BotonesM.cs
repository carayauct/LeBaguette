using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesM : MonoBehaviour
{
    public Boton[] botones;
    public int posicion = 0;
 
    void Start()
    {
        botones[posicion].seleccionado = true;


    }

    void Update()
    {
        

        if (Input.GetAxis("Horizontal") == -1f || Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(Example());
            botones[posicion].seleccionado = false;
            posicion++;

            if (posicion < 0)
            {
                posicion = botones.Length - 1;
                botones[posicion].seleccionado = true;
                return;
            }
            if (posicion > botones.Length - 1)
            {
                posicion = 0;
                botones[posicion].seleccionado = true;
                return;
            }

            botones[posicion].seleccionado = true;

        }


        if (Input.GetAxis("Horizontal") == 1f || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            botones[posicion].seleccionado = false;
            posicion--;

            if (posicion < 0)
            {
                posicion = botones.Length - 1;
                botones[posicion].seleccionado = true;
                return;
            }
            if (posicion > botones.Length - 1)
            {
                posicion = 0;
                botones[posicion].seleccionado = true;
                return;
            }

            botones[posicion].seleccionado = true;
        }

        IEnumerator Example()
        {
            yield return new WaitForSeconds(1);
        }
    }
}