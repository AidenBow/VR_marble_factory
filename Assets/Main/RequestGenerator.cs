using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RequestGenerator : MonoBehaviour
{
    public string request;
    public TMP_Text text;
    void Start()
    {
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
            request = "rectangle";
        } else if (randomNum < 7)
        {
            request = "sphere";
        } else
        {
            request = "cylinder";
        }

        text.text = request;
    }

}
