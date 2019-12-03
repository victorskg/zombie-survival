using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject menuPauseUi;
    private static bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void resume()
    {
        menuPauseUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void pause()
    {
        menuPauseUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void sairParaMenu()
    {
        SceneManager.LoadScene("Interface");
        resume();
    }

    public void reiniciarGame()
    {
        SceneManager.LoadScene("SampleScene");
        resume();
    }
}
