using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class level4_img_exampleclass : MonoBehaviour
{
    private Sprite sprite;
    public GameObject Img_1;
    public static int generatedNum;

    // Start is called before the first frame update
    void Start()
    {
        generatedNum = UnityEngine.Random.Range(52, 67);
        //generatedNum = 62;


        Img_1.AddComponent(typeof(Image));
        sprite = Resources.Load<Sprite>("Level_4/" + "sprite" + generatedNum);
        Img_1.GetComponent<Image>().sprite = sprite;
    }



}
