// Loading assets from the Resources folder using the generic Resources.Load<T>(path) method
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    private Sprite sprite;
    public GameObject Img_1;
    public static int generatedNum;

    // Start is called before the first frame update
    void Start()
    {
        generatedNum = UnityEngine.Random.Range(1,21);
        //generatedNum = 19;
      

        Img_1.AddComponent(typeof(Image));
        sprite = Resources.Load<Sprite>("Level_1/" + "sprite" + generatedNum);
        Img_1.GetComponent<Image>().sprite = sprite;
    }

   

}