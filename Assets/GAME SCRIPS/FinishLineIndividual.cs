using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineIndividual : MonoBehaviour
{
    public string horseName; // Asigna el nombre del caballo asociado a esta línea de llegada
    public RaceManager raceManager; // Referencia al script central que gestiona la carrera

    private void OnTriggerEnter(Collider other)

    {
        Debug.Log("Trigger activado por: " + other.gameObject.name);
        if (other.gameObject.name == horseName)


        {
            raceManager.RecordFinish(horseName);
        }
        if (other.gameObject.name == horseName)
        {
            raceManager.RecordFinish(horseName);
        }
    }
}
