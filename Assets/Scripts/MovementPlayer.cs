using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MovementPlayer : MonoBehaviour
{
    private Rigidbody2D Player;
    private SpriteRenderer spriteRenderer;
    public float Speed;
    float Movement;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Player = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        Movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(Movement * Speed * Time.deltaTime, 0, 0);
        if(Movement < 0) {
            spriteRenderer.flipX = true;
        }
        else if(Movement > 0) 
        {
            spriteRenderer.flipX = false;
        }

    }
}
