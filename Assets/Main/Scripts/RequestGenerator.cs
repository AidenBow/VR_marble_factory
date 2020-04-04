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

    public void Update()
    {
        requests.ForEach(request =>
        {
            request.Time -= Time.deltaTime;
            if (request.Time <= 0)
            {
                requests.Remove(request);
            }
        });
        UpdateText();
    }

    public void GenNewShape()
    {
        float randomNum = Random.Range(0f, 9f);
        if (randomNum < 4)
        {
            RequestObject newRequest = new RequestObject() { Shape = "rectangle", Color = "red", Time = 30f };
            requests.Add(newRequest);
        } else if (randomNum < 7)
        {
            RequestObject newRequest = new RequestObject() { Shape = "sphere", Color = "red", Time = 30f };
            requests.Add(newRequest);
        } else
        {
            RequestObject newRequest = new RequestObject() { Shape = "cylinder", Color = "red", Time = 30f };
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
                text.text += requests[i].Time.ToString("0.00") + "  "+ requests[i].Color +"  "+requests[i].Shape;
            }
            else
            {
                text.text += "\n" + requests[i].Time.ToString("0.00") + "  " + requests[i].Color + "  " + requests[i].Shape;
            }

        }
    }

}
