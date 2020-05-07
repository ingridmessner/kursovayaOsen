using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public void PlayGame() // метод для запуска следующую по порядку сцену
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame() // метод для закрытия игры
    {
        

        Application.Quit();
    }
}
