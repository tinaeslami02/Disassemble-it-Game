using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Proyecto26;

public class DrawRect_comp : MonoBehaviour
{
    //[SerializeField]

    private LineRenderer lineRend;
    private Vector2 initialMousePosition, currentMousePosition;
    private float area;
    public GameObject error_message;
    public GameObject nextbtn;

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

            //Debug.Log("x0 =" + initialMousePosition.x + " y0 =" + initialMousePosition.y +
            //   " x1 =" + initialMousePosition.x + " y1 =" + currentMousePosition.y +
            //   " x2 =" + currentMousePosition.x + " y2 =" + currentMousePosition.y +
            //   " x3 =" + currentMousePosition.x + " y3 =" + initialMousePosition.y);

            area = Mathf.Abs(
                (initialMousePosition.x - currentMousePosition.x) *
                (initialMousePosition.y - currentMousePosition.y));

            Debug.Log(area);

            if (area > 0.1)
            {
                error_message.SetActive(false);
                nextbtn.SetActive(true);

            }

            if (area > 5)
            {
                error_message.SetActive(true);
                nextbtn.SetActive(false);

            }
            else
            {
                error_message.SetActive(false);
                nextbtn.SetActive(true);
            }

            if (area == 0)
            {
                nextbtn.SetActive(false);
            }

            //RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + comp_img_exampleclass.generatedNum + "/x0,x1,y0,y3" + ".json", new Vector2(initialMousePosition.x, initialMousePosition.y));
            //RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + comp_img_exampleclass.generatedNum + "/x2,x3,y1,y2" + ".json", new Vector2(currentMousePosition.x, currentMousePosition.y));
            RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + comp_img_exampleclass.generatedNum + "/xmax,xmin" + ".json", new Vector2(currentMousePosition.x, initialMousePosition.x));
            RestClient.Put("https://unitygame-83bfb-default-rtdb.firebaseio.com/" + FireBaseName.playerName + "/sprite" + comp_img_exampleclass.generatedNum + "/ymax,ymin" + ".json", new Vector2(currentMousePosition.y, initialMousePosition.y));
        }

    }

    public void restartbb()
    {
        area = 0;
        nextbtn.SetActive(false);
    }
}
