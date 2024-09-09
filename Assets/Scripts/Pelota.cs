using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pelota : MonoBehaviour
{
    public Vector2 InicialVelocity;
    private Rigidbody2D PelotaRb;
    bool ismoving;
    public Score Sumarscore;
    public int NivelActual;
    public Text launchText;
    bool lanzo = false; 
    void Start()
    {
        Time.timeScale = 0f;
        PelotaRb = GetComponent<Rigidbody2D>();
        

    }
    


    void Update()
    {
       if (Input.GetKeyUp(KeyCode.E) && lanzo == false) 
        {
            Time.timeScale = 1f;
            launchText.enabled = false;
            lanzo = true;
        }


        if (!ismoving)
        {
            PelotaRb.velocity = InicialVelocity;
            ismoving = true;
        }
        Victory();
        
    }
    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.gameObject.CompareTag("Ladrillo"))
        {
            Sumarscore.Contador(10);
            Destroy(choque.gameObject);

        }
    }
    void Victory()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Ladrillo");
        if (bricks.Length == 0) 
        {
            SceneManager.LoadScene(NivelActual+1);


        }

    }



}
