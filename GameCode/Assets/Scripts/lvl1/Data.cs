using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Data
{
    public string Label_Image;

    public Data()
    {
        Label_Image = FireBaseLabel.LabelByPlayer;
    }

}