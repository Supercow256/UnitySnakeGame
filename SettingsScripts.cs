using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScripts : MonoBehaviour
{

    public Text snakeSizeText;
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
    }
}
