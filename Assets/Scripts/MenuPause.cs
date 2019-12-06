using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour
{
    public GameObject menuPauseUi;
    public Button retomar;
    public Button reiniciar;
    public Button sair;

    private AudioSource playerAudio;
    private AudioSource zombieAudio;

    private static bool gameIsPaused = false;
    
    void Start()
    {
        playerAudio = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
        zombieAudio = GameObject.FindGameObjectWithTag("GameController").GetComponent<AudioSource>();
        retomar.onClick.AddListener(Resume);
        reiniciar.onClick.AddListener(reiniciarGame);
        sair.onClick.AddListener(sairParaMenu);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void Resume()
    {
        menuPauseUi.SetActive(false);
        Time.timeScale = 1f;
        zombieAudio.mute = false;
        playerAudio.mute = false;
        gameIsPaused = false;
    }

    void pause()
    {
        menuPauseUi.SetActive(true);
        Time.timeScale = 0f;
        playerAudio.mute = true;
        zombieAudio.mute = true;
        gameIsPaused = true;
    }

    public void sairParaMenu()
    {
        SceneManager.LoadScene("Interface");
        Hud.kills = 0;
        Resume();
    }

    public void reiniciarGame()
    {
        SceneManager.LoadScene("SampleScene");
        Hud.kills = 0;
        Resume();
    }
}
