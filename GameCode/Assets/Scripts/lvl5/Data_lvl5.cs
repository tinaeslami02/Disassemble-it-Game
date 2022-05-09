using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Data_lvl5
{
    public string Label_Image;

    public Data_lvl5()
    {
        Label_Image = FireBaseLabel_lvl5.LabelByPlayer;
    }

}
