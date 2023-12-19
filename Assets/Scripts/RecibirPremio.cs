using UnityEngine;
using UnityEngine.UI;

public class RecibirPremio : MonoBehaviour
{
    public Marcador marcador; 
    public int puntosPremio; 

    void Start()
    {
        
        if (marcador == null)
        {
            Debug.LogError("El objeto de marcador no est� asignado en el Inspector.");
        }
    }

    // M�todo que se llama cuando se presiona el bot�n
    public void OnBotonPremiosClick()
    {
        // Verifica si el jugador tiene suficientes puntos para el premio
        if (marcador.score >= puntosPremio)
        {
            
            int nuevoPuntaje = marcador.score - puntosPremio;
            marcador.ActualizarMarcador(nuevoPuntaje);
        }
        else
        {
            Debug.Log("No tienes puntos suficientes para este premio");
        }
    }
}
