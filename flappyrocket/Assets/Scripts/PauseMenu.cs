using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused= false; //переменная для определения паузы игры на данный момент
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // при нажатии клавиши ecs игра останавливается
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else 
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
       pauseMenuUI.SetActive(false);
       Time.timeScale = 1f;
       GameIsPaused = false;
    }

    void Pause ()
    {
       pauseMenuUI.SetActive(true); // остановка игры
       Time.timeScale = 0f;
       GameIsPaused = true;
    }

    public void LoadMenu()
    {
         Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    
}
