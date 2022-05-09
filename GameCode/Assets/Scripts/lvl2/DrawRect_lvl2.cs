using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Proyecto26;

public class DrawRect_lvl2 : MonoBehaviour
{
    //[SerializeField]

    private LineRenderer lineRend;
    private Vector2 initialMousePosition, currentMousePosition;
    private float area;
    public GameObject nextBtn;

    // Start is called before the first frame update
    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            lineRend.positionCount = 4;
            initialMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineRend.SetPosition(0, new Vector2(initialMousePosition.x, initialMousePosition.y));
            lineRend.SetPosition(1, new Vector2(initialMousePosition.x, initialMousePosition.y));
            lineRend.SetPosition(2, new Vector2(initialMousePosition.x, initialMousePosition.y));
            lineRend.SetPosition(3, new Vector2(initialMousePosition.x, initialMousePosition.y));
        }

        if (Input.GetMouseButton(1))
        {
            currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineRend.SetPosition(0, new Vector2(initialMousePosition.x, initialMousePosition.y));
            lineRend.SetPosition(1, new Vector2(initialMousePosition.x, currentMousePosition.y));
            lineRend.SetPosition(2, new Vector2(currentMousePosition.x, currentMousePosition.y));
            lineRend.SetPosition(3, new Vector2(currentMousePosition.x, initialMousePosition.y));

            area = Mathf.Abs(
               (initialMousePosition.x - currentMousePosition.x) *
               (initialMousePosition.y - currentMousePosition.y));

            //RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + level2_img_exampleclass.generatedNum + "/x0,x1,y0,y3" + ".json", new Vector2(initialMousePosition.x, initialMousePosition.y));
            //RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + level2_img_exampleclass.generatedNum + "/x2,x3,y1,y2" + ".json", new Vector2(currentMousePosition.x, currentMousePosition.y));
            RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + level2_img_exampleclass.generatedNum + "/xmax,xmin" + ".json", new Vector2(currentMousePosition.x, initialMousePosition.x));
            RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + level2_img_exampleclass.generatedNum + "/ymax,ymin" + ".json", new Vector2(currentMousePosition.y, initialMousePosition.y));
        }

        if (area > 0)
        {
            nextBtn.SetActive(true);
        }
        else
        {
            nextBtn.SetActive(false);
        }
    }
}