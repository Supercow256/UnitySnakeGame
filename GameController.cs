using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform SnakePreFab;
    // Start is called before the first frame update
    void Start()
    {
        Transform segment = Instantiate(this.SnakePreFab);
    }

    void Update()
    {

        //Close Game
        if (Input.GetKey(KeyCode.Escape))
        {
            FindObjectOfType<GameController>().ExitGame();
        }


    }
    public void LoadSnakeGame()
    {
        SceneManager.LoadScene("SnakeMain");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene("StartScreen");

    }

    public void EndGame()
    {
        SceneManager.LoadScene("GameOverScene");

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SettingsScreen()
    {

        SceneManager.LoadScene("SettingsScene");
    }

    public void GlobalVars()
    {
        //public int intitalSnakeSize;
    }

}
