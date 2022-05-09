using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public string level1;

    public void StartGame()
    {
        if (FireBaseName.playerName != "")
        {
            SceneManager.LoadScene(level1);
        }
    }

}
