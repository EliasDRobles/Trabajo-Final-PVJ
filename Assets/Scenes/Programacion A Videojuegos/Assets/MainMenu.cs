using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("OptionsMenu")]
    public Slider volumen;
    public Slider brillo;
    
    [Header("Menus")]
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject playMenu;

    
    
    public void OpenMenu( GameObject menu)
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        playMenu.SetActive(false);

        menu.SetActive(true);
    }
    public void PlayGame(string level) 
    {
        SceneManager.LoadScene(level);
       
    
    }
    public void QuitGame() {
    
        Application.Quit();
    
    }
}