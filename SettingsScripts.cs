using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScripts : MonoBehaviour
{

    public Text snakeSizeText;
    //public GameObject snakePreFab;

    //GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("SnakeMain");
        //System.Threading.Thread.Sleep(100);
        //Debug.Log(Player.GetComponent<SnakeMovement>().initialSize);
        //System.Threading.Thread.Sleep(100);
        //SceneManager.LoadScene("SettingsScene");

        //Player = GameObject.Find("SnakePreFab(Clone)");
        //settingsInitialSize =Player.GetComponent<SnakeMovement>().initialSize;
        //Debug.Log(settingsInitialSize);

            
           
    }

    // Update is called once per frame
    void Update()
    {
        //settingsInitialSize = Player.GetComponent<SnakeMovement>().initialSize;
        snakeSizeText.text = "" + GlobalVars.initSize;
        //PlayerPrefs.SetInt("InitialSnakeSize",snakeSizeText);
    }

    public void DecreaseSnakeSize()
    {
        if(GlobalVars.initSize > 1)
        GlobalVars.initSize--;
    }

    public void IncreaseSnakeSize()
    {
        GlobalVars.initSize++;
    }

    public void ChangeDifficulty(int difficulty)
    {
        // 0 is medium, 1 is easy, 2 is hard
        if (difficulty == 0)
        {
            Time.fixedDeltaTime = 0.12f;

        }
        else if (difficulty == 1)
        {
            Time.fixedDeltaTime = 0.12f;

        }
        else if (difficulty == 2)
        {
            Time.fixedDeltaTime = 0.08f;
        }
        //Debug.Log(difficulty);
    }
}
