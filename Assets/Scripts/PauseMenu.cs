using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void onContinueButtonClicked()
    {
        gameObject.SetActive(false);
    }
    
    public void onRestartButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void onMenuButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
}
