using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void PlayBtn()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitBtn()
    {
        Application.Quit();
        print("We exit the game!");
    }
}
