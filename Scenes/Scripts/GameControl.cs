using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject replayBtn;
    public GameObject mainMenu;
    // Start is called before the first frame update
    public void ReplayGame()
    {
        replayBtn.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 

    }
    public void MainMenu()
    {
        mainMenu.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
