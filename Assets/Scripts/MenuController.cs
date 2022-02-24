using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void stratGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void onOptionButtonClicked(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
