using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RequestGenerator : MonoBehaviour
{
    public List<string> requests;
    public TMP_Text text;
    void Start()
    {
        GenNewShape();
        GenNewShape();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenNewShape()
    {
        float randomNum = Random.Range(0f, 9f);

        if (randomNum < 4)
        {
            requests.Add("rectangle");
        } else if (randomNum < 7)
        {
            requests.Add("sphere");
        } else
        {
            requests.Add("cylinder");
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
                text.text += requests[i];
            }
            else
            {
                text.text += "\n" + requests[i];
            }

        }
    }

}
