using UnityEngine;
using UnityEngine.UI;
using TMPro;

public  class Marcador : MonoBehaviour
{
    public TextMeshProUGUI textoMarcador;
    public int score = 0;

    // M�todo para actualizar el marcador
    public void ActualizarMarcador(int nuevoPuntaje)
    {
        score = nuevoPuntaje;
        textoMarcador.text = score.ToString();
    }
}
