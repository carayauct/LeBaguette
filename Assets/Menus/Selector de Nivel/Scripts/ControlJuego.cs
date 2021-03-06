using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlJuego : MonoBehaviour
{
    static public int nivelesDesbloqueados;
    public int nivelActual;
    public Button[] botonesMenu;
    CargaryGuardar cargaryGuardar;


    private void Awake()
    {
        cargaryGuardar = GetComponent<CargaryGuardar>(); 
    }
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "LevelSelectorTest")
        {
            cargaryGuardar.Guardar();
            actualizarBotones();
        }
    }
    public void cambiarNivel(int nivel)
    {
        if (nivel == 0)
            SceneManager.LoadScene("LevelSelectorTest");
        else
            LevelLoader.LoadLevel("Nivel " + nivel);
            BGmusic.instance.GetComponent<AudioSource>().Pause();

    }

    public void desbloquearNivel()
    {
        if(nivelesDesbloqueados < nivelActual)
        {
            nivelesDesbloqueados = nivelActual;
            nivelActual++;

        }
    }

    public void actualizarBotones()
    {
        for (int i = 0; i < nivelesDesbloqueados + 1; i++)
        {
            botonesMenu[i].GetComponent<Image>().color = new Color(255, 255, 255);
            botonesMenu[i].interactable = true;
        }    
            
    }
}
