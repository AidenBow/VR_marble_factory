using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public Material orange;
    public Material red;
    public Material yellow;
    public Material blue;
    public Material green;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.transform.name)
        {
            case "OrangeBucket" :
                GetComponent<Renderer>().material = orange;
                GetComponent<CustomTags>().ResetColorTags();
                GetComponent<CustomTags>().AddTag("orange");
                break;
            case "RedBucket":
                GetComponent<Renderer>().material = red;
                GetComponent<CustomTags>().ResetColorTags();
                GetComponent<CustomTags>().AddTag("red");
                break;
            case "YellowBucket":
                GetComponent<Renderer>().material = yellow;
                GetComponent<CustomTags>().ResetColorTags();
                GetComponent<CustomTags>().AddTag("yellow");
                break;
            case "BlueBucket":
                GetComponent<Renderer>().material = blue;
                GetComponent<CustomTags>().ResetColorTags();
                GetComponent<CustomTags>().AddTag("blue");
                break;
            case "GreenBucket":
                GetComponent<Renderer>().material = green;
                GetComponent<CustomTags>().ResetColorTags();
                GetComponent<CustomTags>().AddTag("green");
                break;
            default:
                break;
        }
    }
}
