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

    /*
    En este codigo tome referencias de dos videos del canal Alexander Zotov, para generar 
    los enemigos en pantalla y de forma aleatorea, modifique un poco el codigo
    para que se apropiara mas a lo que es la tarea en mano
    (https://www.youtube.com/watch?v=AI8XNNRpTTw / https://www.youtube.com/watch?v=q1gAtOWTs-o)
    */
    void Update()
    {
        
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            //Aqui use los comandos de random para generear de forma aleatorea donde
            //se crearian los enemigos en un rango determinado de la camara
            randX = Random.Range (-8.89f, 8.89f);
            randY = Random.Range (-5f, 5f);
            whereToSpawn = new Vector2 (randX, randY);
            randomMob = Random.Range (0,Mob.Length);
            //Aqui instancea mis listas y donde apareceran, junto con el uso de 
            //quaternion que se usa para la rotacion, pero en este caso es para que no alla
            Instantiate(Mob[randomMob], whereToSpawn,Quaternion.identity);
        }
        
    }
}
