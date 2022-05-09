using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class Label_lvl3 : MonoBehaviour
{
    public static string LabelByPlayer;
    public GameObject dropdownLabel;

    public void send()
    {
        Text dropdownText = dropdownLabel.GetComponent<Text>();
        string dropdownValue = dropdownText.text;
        LabelByPlayer = dropdownText.text;
    }
}
