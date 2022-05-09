using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Data_lvl6
{
    public string Label_Image;

    public Data_lvl6()
    {
        Label_Image = FireBaseLabel_lvl6.LabelByPlayer;
    }

}