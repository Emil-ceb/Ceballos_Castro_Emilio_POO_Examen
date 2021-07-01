 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 3, Genera un punto de Spawneo o instanciación de
enemigos
Descripcion: Creacion de monstruos de manera aleatoria.
*/

public class Spawn : MonoBehaviour
{
    public GameObject[] Mob;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float nextSpawn = 0.0f;
    int randomMob;

    void Update()
    {
        if(Time.time > nextSpawn){
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range (-8.89f, 8.89f);
            randY = Random.Range (-5f, 5f);
            whereToSpawn = new Vector2 (randX, randY);
            randomMob = Random.Range (0,Mob.Length);
            Instantiate(Mob[randomMob], whereToSpawn,Quaternion.identity);
        }
        
    }
}
