using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    private PlayerLife playerLife;
    public Sprite[] bar;
    private Image healtbar;
    private Text cronometro;
    private float timer = 0f;

    void Start()
    {
        playerLife = GameObject.Find("Player").GetComponent<PlayerLife>();
        healtbar = GameObject.FindGameObjectWithTag("Hud").GetComponentInChildren<Image>();
        cronometro = GameObject.FindGameObjectWithTag("Hud").GetComponentInChildren<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        healtbar.sprite = bar[playerLife.getHp()/playerLife.getDano()];
        cronometro.text = "Tempo decorrido: " + timer.ToString("F0") + "s";
    }
}
