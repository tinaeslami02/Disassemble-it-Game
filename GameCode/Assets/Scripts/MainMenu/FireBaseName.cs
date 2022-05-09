using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using UnityEngine.SceneManagement;

public class FireBaseName : MonoBehaviour
{

    public InputField Nametext;
    public static string playerName;
    public GameObject error_msg;
    public GameObject error_msg2;
    public string level1;
    public static int generatedNum;

    public void send()
    {
        generatedNum = UnityEngine.Random.Range(1, 1000);
        playerName = Nametext.text;

        if (playerName == "")
        {
            error_msg.SetActive(true);
        }
        sendByPost();
    }

    public void sendByPost()
    {
        User user = new User();
        if (playerName != "")
        {
            playerName = playerName + generatedNum;
            RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + playerName + ".json", user);
            SceneManager.LoadScene(level1);
        }
    }
}
