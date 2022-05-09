using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Data_lvl4
{
    public string Label_Image;

    public Data_lvl4()
    {
        Label_Image = FireBaseLabel_lvl4.LabelByPlayer;
    }

}
