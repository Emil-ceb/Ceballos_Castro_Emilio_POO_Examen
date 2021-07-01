
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 1, Crea un controlador de personaje completo para un
juego de plataforma con movimiento y animaciones
Descripcion: Asignar componentes e inputs de teclado.
*/

public class InputControl : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    Animator animPlayer;

    private void Awake() 
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);


        //Me genera el volteo del personaje
        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2 (body.velocity.x, speed);
        }
        
    }
}
