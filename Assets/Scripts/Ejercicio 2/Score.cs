using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 2, Crearas un sistema de retroalimentación de progreso de
usuario a traves de UI GameObject en Unity para un juego de plataforma
Descripcion: Contador de puntos/score.
*/

public class Score : MonoBehaviour
{
    [SerializeField]private float points;

    public Score (float p)
    {
        this.points=p;

    }
}
