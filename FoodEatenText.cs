using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodEatenText : MonoBehaviour
{

    //GameObject Player;
    public Text foodEatenText;
    public Text timeText;
    //GameObject Player = GameObject.Find("Snake");

    float time = 0;
    //PlayerScript playerScript = player.GetComponent<SnakeMovement>();
    //Player = Player.GetComponent<PlayerScript>();
    // Start is called before the first frame update
    void Start()
    {
    //Player = GameObject.Find("Snake");

    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        foodEatenText.text = "Food Eaten: " + GlobalVars.foodEaten;//GameObject.Find("SnakePreFab(Clone)").GetComponent<SnakeMovement>().foodEaten;
        timeText.text = "Score: " + (int)time;
        //KeepTime();
        //GetComponent<UnityEngine.UI.FoodEaten>().text = "" + Player.foodEaten;
    }
    
    public void KeepTime()
    {

        int i = 0;
        while (i == 0)
        {
            time++;
            System.Threading.Thread.Sleep(1000);
            i++;
        }
        
    }
    
}
