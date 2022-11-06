using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaVida : MonoBehaviour
{
    public Image sistemaVida;

    public float vidaActual;

    public float vidaMaxima;

    void Update()
    {
        sistemaVida.fillAmount = vidaActual / vidaMaxima;
    }

}
