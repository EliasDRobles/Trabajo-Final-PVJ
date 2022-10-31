using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Muestra los controles en medio la partida y la pantalla al fina
public class GameOver : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject ObjetivoControl;
    public static GameObject GameOverStatic;
    public static GameObject ObjConStatic;
    

    void Start()
    {
        GameOverStatic = GameOverText;
        GameOverStatic.SetActive(false);
        ObjConStatic = ObjetivoControl;
        ObjConStatic.SetActive(true);
    }


    public static void Show()
    {
        GameOverStatic.SetActive(true);
        ObjConStatic.SetActive(false);
    }

}