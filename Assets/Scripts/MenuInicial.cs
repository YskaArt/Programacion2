using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public int NivelActual;
    public void Iniciar()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(NivelActual + 1);

    }

    public void Salir()
    {
        Application.Quit();

    }
}
