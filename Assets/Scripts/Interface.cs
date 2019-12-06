using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public Button iniciar;
    public Button creditos;

    void Start()
    {
        iniciar.onClick.AddListener(StartGame);
        creditos.onClick.AddListener(Creditos);
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
}
