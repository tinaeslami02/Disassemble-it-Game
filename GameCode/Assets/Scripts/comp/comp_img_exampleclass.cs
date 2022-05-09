using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class comp_img_exampleclass : MonoBehaviour
{
    private Sprite sprite;
    public GameObject Img_1;
    public static int generatedNum;

    // Start is called before the first frame update
    public void Start()
    {
        generatedNum = UnityEngine.Random.Range(86, 118);


        Img_1.AddComponent(typeof(Image));
        sprite = Resources.Load<Sprite>("Comp/" + "sprite" + generatedNum);
        Img_1.GetComponent<Image>().sprite = sprite;
    }



}

