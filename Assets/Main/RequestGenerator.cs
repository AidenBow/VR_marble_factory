using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RequestGenerator : MonoBehaviour
{
    public List<RequestObject> requests;
    public TMP_Text text;
    void Start()
    {
        GenNewShape();
        GenNewShape();

    }

    public void GenNewShape()
    {
        float randomNum = Random.Range(0f, 9f);
        if (randomNum < 4)
        {
            RequestObject newRequest = new RequestObject("rectangle", "red", 30);
            requests.Add(newRequest);
        } else if (randomNum < 7)
        {
            RequestObject newRequest = new RequestObject("sphere", "red", 30);
            requests.Add(newRequest);
        } else
        {
            RequestObject newRequest = new RequestObject("cylinder", "red", 30);
            requests.Add(newRequest);
        }

        UpdateText();
    }

    public void UpdateText()
    {
        text.text = "";
        for (int i = 0; i < requests.Count; i++)
        {
            if (text.text == "")
            {
                text.text += requests[i].Color +"  "+requests[i].Shape;
            }
            else
            {
                text.text += "\n" + requests[i].Color + "  " + requests[i].Shape;
            }

        }
    }

}
