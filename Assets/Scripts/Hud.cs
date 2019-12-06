using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hud : MonoBehaviour {

    public Sprite[] bar;
    public Text killsText;
    public Text cronometro;
    public Image healtbar;

    private float timer = 0f;
    private PlayerHealth playerHealth;

    public static int kills = 0;

    void Start() {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
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
        cronometro.text = "Tempo de missão: " + timer.ToString("F0") + "s";
        killsText.text = "Zumbis eliminados: " + kills;
    }
}
