using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

    public Sprite[] bar;
    private Image healtbar;
    private Text cronometro;
    private float timer = 0f;
    private PlayerHealth playerHealth;

    void Start() {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        healtbar = GameObject.FindGameObjectWithTag("Hud").GetComponentInChildren<Image>();
        cronometro = GameObject.FindGameObjectWithTag("Hud").GetComponentInChildren<Text>();
    }

    void Update() {
        timer += Time.deltaTime;
        healtbar.sprite = bar[playerHealth.GetHealth() / playerHealth.GetDamage()];
        cronometro.text = "Tempo decorrido: " + timer.ToString("F0") + "s";
    }
}
