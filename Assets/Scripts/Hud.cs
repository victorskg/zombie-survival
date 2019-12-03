using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hud : MonoBehaviour {

    public Sprite[] bar;
    private Image healtbar;
    private Text cronometro;
    public Text killsText;
    private float timer = 0f;
    private PlayerHealth playerHealth;
    public static int kills = 0;

    void Start() {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        healtbar = GameObject.FindGameObjectWithTag("Hud").GetComponentInChildren<Image>();
        cronometro = GameObject.FindGameObjectWithTag("Hud").GetComponentInChildren<Text>();
    }

    void Update() {
        if(playerHealth.GetHealth() == 0)
        {
            SceneManager.LoadScene("GameOver");
            Pontuacao.tempo = timer;
            Pontuacao.kills = kills;
        }
        timer += Time.deltaTime;
        healtbar.sprite = bar[playerHealth.GetHealth() / playerHealth.GetDamage()];
        cronometro.text = "Tempo decorrido: " + timer.ToString("F0") + "s";
        killsText.text = "Inimigos eliminados: " + kills;
    }
}
