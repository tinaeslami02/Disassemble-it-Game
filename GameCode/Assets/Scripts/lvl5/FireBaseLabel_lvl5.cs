using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class FireBaseLabel_lvl5 : MonoBehaviour
{
    public static string LabelByPlayer;
    public GameObject dropdownLabel;

    public void send()
    {
        Text dropdownText = dropdownLabel.GetComponent<Text>();
        string dropdownValue = dropdownText.text;
        LabelByPlayer = dropdownText.text;
        sendByPost();
    }

    public void sendByPost()
    {
        Data_lvl5 data = new Data_lvl5();
        User user = new User();
        RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + level5_img_exampleclass.generatedNum + ".json", data);

    }
}
