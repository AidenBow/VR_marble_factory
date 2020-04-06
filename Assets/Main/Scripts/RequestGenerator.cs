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
        float randomNum = Random.Range(0, 20);
        switch (randomNum)
        {
            case 0:
                requests.Add(new RequestObject() { Shape = "cube", Color = "red", Time = 30f });
                break;

            case 1:
                requests.Add(new RequestObject() { Shape = "cube", Color = "blue", Time = 30f });
                break;

            case 2:
                requests.Add(new RequestObject() { Shape = "cube", Color = "orange", Time = 30f });
                break;

            case 3:
                requests.Add(new RequestObject() { Shape = "cube", Color = "yellow", Time = 30f });
                break;

            case 4:
                requests.Add(new RequestObject() { Shape = "cube", Color = "green", Time = 30f });
                break;

            case 5:
                requests.Add(new RequestObject() { Shape = "rectangle", Color = "red", Time = 30f });
                break;

            case 6:
                requests.Add(new RequestObject() { Shape = "rectangle", Color = "blue", Time = 30f });
                break;

            case 7:
                requests.Add(new RequestObject() { Shape = "rectangle", Color = "orange", Time = 30f });
                break;

            case 8:
                requests.Add(new RequestObject() { Shape = "rectangle", Color = "yellow", Time = 30f });
                break;

            case 9:
                requests.Add(new RequestObject() { Shape = "rectangle", Color = "green", Time = 30f });
                break;

            case 10:
                requests.Add(new RequestObject() { Shape = "cylinder", Color = "red", Time = 30f });
                break;

            case 11:
                requests.Add(new RequestObject() { Shape = "cylinder", Color = "blue", Time = 30f });
                break;

            case 12:
                requests.Add(new RequestObject() { Shape = "cylinder", Color = "orange", Time = 30f });
                break;

            case 13:
                requests.Add(new RequestObject() { Shape = "cylinder", Color = "yellow", Time = 30f });
                break;

            case 14:
                requests.Add(new RequestObject() { Shape = "cylinder", Color = "green", Time = 30f });
                break;

            case 15:
                requests.Add(new RequestObject() { Shape = "cube", Color = "red", Time = 30f });
                break;

            case 16:
                requests.Add(new RequestObject() { Shape = "cube", Color = "blue", Time = 30f });
                break;

            case 17:
                requests.Add(new RequestObject() { Shape = "cube", Color = "orange", Time = 30f });
                break;

            case 18:
                requests.Add(new RequestObject() { Shape = "cube", Color = "yellow", Time = 30f });
                break;

            case 19:
                requests.Add(new RequestObject() { Shape = "cube", Color = "green", Time = 30f });
                break;

            default:
                print("default inside request gen");
                requests.Add(new RequestObject() { Shape = "cube", Color = "green", Time = 30f });
                break;
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
