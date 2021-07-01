using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 3, Genera un punto de Spawneo o instanciación de
enemigos
Descripcion: Almacenamiento de informacion de enemigos.
*/

public class Mobs : MonoBehaviour
{
    public int mobId;
    public string summon;
    public Mobs [] newMob;
    
    void Awake() {
        newMob=new Mobs[3];

        newMob[0]=new Mobs(1,"Ghost");
        newMob[1]=new Mobs(2,"Hell Cat");
        newMob[2]=new Mobs(3,"Skeleton");
        
    }

    void Start() 
    {
        loadData(mobId);
        
    }
    /*
    En este codigo solo use codigos de otras clases para tomar los datos de
    cada enemigo y sacarlos en pantalla de acuerdo a su id
    */
    void loadData(int m)
    {
        for (int i = 0; i < newMob.Length; i++)
        {
            if (newMob[i].mobId==m)
            {
                this.summon=newMob[i].summon;
            }
        }

    }
    
    public Mobs(int m, string s)
    {
        this.mobId=m;
        this.summon=s;
    }
}
