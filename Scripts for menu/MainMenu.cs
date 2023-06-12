using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("LevelFirst");
    }
    public void ExitGame()
    {
        Debug.Log("Game is closed");
        Application.Quit(); //выход из игры
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene("LevelSecond");
    }
}
