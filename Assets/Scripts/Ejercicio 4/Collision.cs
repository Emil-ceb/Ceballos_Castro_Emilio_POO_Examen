using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 5, Crea registro de colisiones con ítems
Descripcion: Creara colision con items y dara un puntaje.
*/

public class Collision : MonoBehaviour
{
    public float itemB;
    public float score; 

    private void OnCollisionEnter2D(Collision2D other)
     {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Items>().boxP(itemB);
            gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Score>().scoreP(score);
        }
    }
}
