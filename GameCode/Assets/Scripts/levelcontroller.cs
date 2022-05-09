using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelcontroller : MonoBehaviour
{
    public string movetolevel;

    public void StartGame()
    {
        SceneManager.LoadScene(movetolevel);
    }
}