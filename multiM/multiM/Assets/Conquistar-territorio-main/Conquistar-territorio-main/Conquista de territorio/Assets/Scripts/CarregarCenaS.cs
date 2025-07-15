using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenaS : MonoBehaviour
{
    public void loadScene(string Ceninha)
    {
        SceneManager.LoadScene(Ceninha);
    }

    public void RestartGame(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Menu(string CENALOBBY)
    {
        SceneManager.LoadScene(CENALOBBY);
    }
}
