using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Marcador : MonoBehaviour
{
    public TextMeshProUGUI textoMarcador;
    public int score = 0;

    // Método para actualizar el marcador sumando nuevos puntos
    public void ActualizarMarcador(int puntosGanados)
    {
        score += puntosGanados; // Suma los nuevos puntos al puntaje actual
        textoMarcador.text = score.ToString(); // Actualiza el texto del marcador
    }

}

