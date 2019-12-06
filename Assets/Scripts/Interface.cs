using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public Button iniciar;
    public Button creditos;
    public Button sair;

    void Start()
    {
        iniciar.onClick.AddListener(StartGame);
        creditos.onClick.AddListener(Creditos);
        sair.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
