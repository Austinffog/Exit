﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = true;
    public GameObject pauseMenuUi;

    // Update is called once per frame
    void Update()
    {
        //if (GameIsPaused)
        //{
        //    Resume();
        //} else
        //{
        //    Pause();
        //}
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false); //deactivate the pauseMenUi gameobject
        Time.timeScale = 1f; //time to wait before resuming the scene
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
