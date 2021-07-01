using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
Nombre completo: Ceballos Castro Emilio
Asignatura: Programacion Orientada a Objetos
Nombre y numero de ejercicio: Ejercicio 2, Crearas un sistema de retroalimentación de progreso de
usuario a traves de UI GameObject en Unity para un juego de plataforma
Descripcion: Asignar los valores en pantalla.
*/

public class AsignarUI : MonoBehaviour
{
    [Header("Basic Intefaces TMPro")]
    public TMP_Text lifeTXTP;
    public TMP_Text ItemTXTP;
    public TMP_Text ScoreTXTP;

    Life lifeData;
    Items itemData;
    Score scoreData;
    
    // Start is called before the first frame update
    void Start()
    {
        lifeData = GetComponentInParent<Life>();
        itemData = GetComponentInParent<Items>();
        scoreData = GetComponentInParent<Score>();
        StartCoroutine(AsignData(0.1f));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AsignData(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (lifeTXTP != null)
        {
            lifeTXTP.text = lifeData.health.ToString();
        }
        if (lifeTXTP != null)
        {
            ItemTXTP.text = itemData.item.ToString();
        }
        if (lifeTXTP != null)
        {
            ScoreTXTP.text = scoreData.points.ToString();
        }
        
       

    }
}
