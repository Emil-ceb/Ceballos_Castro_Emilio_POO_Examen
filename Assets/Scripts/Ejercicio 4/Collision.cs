using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 4, Crea un sistema general de colisiones
Descripcion: Generara colision y restara vida.
*/

public class Collision : MonoBehaviour
{
    public float daño;

    private void OnCollisionEnter2D(Collision2D other)
     {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Life>().damageP(daño);
            gameObject.SetActive(false);
        }
    }
}
