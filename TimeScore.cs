using UnityEngine;
using UnityEngine.UI;

public class SecondTimer : MonoBehaviour
{
    public GameObject Player;
    public Text timerText;

    int count = 0;


    void Update()
    {
        //textGameObject.GetComponent<UnityEngine.UI.Text>().text = "text";
        timerText.text = "Time: " + count;
    }


}
    