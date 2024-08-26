using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{

    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void EndGame2()
    {
        SceneManager.LoadScene("EndGame2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
