using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Creditos : MonoBehaviour
{
    public Button sair;

    void Start()
    {
        sair.onClick.AddListener(SairParaMenu);
    }

    void Update()
    {
        
    }

    void SairParaMenu()
    {
        SceneManager.LoadScene("Interface");
    }
}
