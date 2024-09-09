using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{

    [SerializeField] private GameObject Pause;
    private bool PauseGame = false;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {  
            if(PauseGame)
            {
                Reanudar();

            }
            else
            {
                Pausa();

            }
        }


    }

    public void Pausa()
    {
        PauseGame = true;
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            Pause.SetActive(true);

        }

    }
    public void Reanudar()
    {
        PauseGame = false;
        Time.timeScale = 1f;
        Pause.SetActive(false);

    }
    public void Reiniciar()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Salir()
    {
        Application.Quit();

    }
}
