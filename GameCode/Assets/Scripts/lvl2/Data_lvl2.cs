using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Data_lvl2
{
    public string Label_Image;

    public Data_lvl2()
    {
        Label_Image = FireBaseLabel_lvl2.LabelByPlayer;
    }

}
