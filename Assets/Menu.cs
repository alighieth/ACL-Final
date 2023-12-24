using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public float audioLevel;
    public float effectsLevel;
    public GameObject menuCanvas;
    public GameObject optionsCanvas;
    public GameObject pauseCanvas;
    public GameObject gameOverCanvas;


    void Start()
    {
        menuCanvas.SetActive(true);
        optionsCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
    }

    public void OnPlayBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnOptionsBtn()
    {
        menuCanvas.SetActive(false);
        optionsCanvas.SetActive(true);
    }

    public void OnOptionsBackBtn()
    {
        menuCanvas.SetActive(true);
        optionsCanvas.SetActive(false);
    }

    public void OnQuitBtn()
    {
        Application.Quit();
    }

    public void OnAudioSlider(float value)
    {
        audioLevel = value;
    }

    public void OnEffectsSlider(float value)
    {
        effectsLevel = value;
    }

    public void OnResumeBtn()
    {
        // TODO: Resume game
    }

    public void OnRestartBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnQuitToMainMenuBtn()
    {
        menuCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
    }
}
