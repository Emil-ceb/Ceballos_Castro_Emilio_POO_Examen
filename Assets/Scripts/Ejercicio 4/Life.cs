using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 2, Crearas un sistema de retroalimentación de progreso de
usuario a traves de UI GameObject en Unity para un juego de plataforma
Descripcion: Contador de vidas.
*/
public class Life : MonoBehaviour
{
    public float health;

    public Life (float hp)
    {
        this.health=hp;
    }

    public void damageP (float daño){
        health -= daño;
    }


}
