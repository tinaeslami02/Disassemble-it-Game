using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User
{
    public string name;

    public User()
    {
        name = FireBaseName.playerName;

    }
}

