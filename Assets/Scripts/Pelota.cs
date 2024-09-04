using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Pelota : MonoBehaviour
{
    public Vector2 InicialVelocity;
    private Rigidbody2D PelotaRb;
    bool ismoving;
    void Start()
    {
        PelotaRb = GetComponent<Rigidbody2D>();

    }
    


    void Update()
    {
        

        if (!ismoving)
        {
            PelotaRb.velocity = InicialVelocity;
            ismoving = true;
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.gameObject.CompareTag("Ladrillo"))
        {

            Destroy(choque.gameObject);

        }
    }
}
