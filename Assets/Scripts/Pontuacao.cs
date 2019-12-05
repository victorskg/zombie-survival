using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Button sair;
    public Button creditos;
    public Text tempoText;
    public Text killsText;
    public static float tempo;
    public static int kills;

    void Start()
    {
        sair.onClick.AddListener(SairParaMenuPrincipal);
        creditos.onClick.AddListener(irParaCreditos);
        tempoText.text = "Tempo de missão: " + tempo.ToString("F0") + "s"; ;
        killsText.text = "Inimigos eliminados: " + kills;
    }

    void Update()
    {
            
    }

    void SairParaMenuPrincipal()
    {
        Hud.kills = 0;
        SceneManager.LoadScene("Interface");
    }

    void irParaCreditos()
    {
        Hud.kills = 0;
        SceneManager.LoadScene("Creditos");
    }
}
