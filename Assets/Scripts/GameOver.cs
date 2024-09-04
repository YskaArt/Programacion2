using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    [SerializeField] private GameObject Gameover;

    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.gameObject.CompareTag("Killzone"))
        {
            Time.timeScale = 0f;
            Gameover.SetActive(true);

        }
    }

    public void Reiniciar()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
