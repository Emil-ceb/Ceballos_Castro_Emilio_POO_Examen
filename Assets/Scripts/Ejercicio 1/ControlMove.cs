using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 1, Crea un controlador de personaje completo para un
juego de plataforma con movimiento y animaciones
Descripcion: Script diseñado para generar el movimiento y asignacion de animaciones.
*/
public class ControlMove : MonoBehaviour
{
    Animator playerAnim;
    InputControl inputCon;



    void Awake() 
    {
        playerAnim= GetComponent<Animator>();
        inputCon = GetComponentInParent<InputControl>();
        
    }

    void Update() 
    {
        ControlAnim();
        
    }

    private void ControlAnim()
    {
        
        //bool directionForward = direction.x != 0 ? true:false;
        

    }



}
