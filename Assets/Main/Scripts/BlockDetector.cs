using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockDetector : MonoBehaviour
{
    public GameObject requestObj;
    public GameObject requestText;
    public GameObject points;
    public bool doneDetecting = true;
    void Start()
    {
        requestObj = GameObject.Find("/RequestGenerator");
        requestText = GameObject.Find("/RequestGenerator/RequestText");
        points = GameObject.Find("/Points");
        doneDetecting = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "placemat" && doneDetecting)
        {
            doneDetecting = false;

            List<string> tags = gameObject.GetComponent<CustomTags>().tags;
            List<RequestObject> requests = requestObj.GetComponent<RequestGenerator>().requests;
            string tagColor = null;
            string tagShape = null;
            int matchedIndex = -1;

            tags.ForEach(delegate (string tag)
            {
                if (tag == "red" || tag == "blue")
                {
                    tagColor = tag;
                    print(tagColor);
                };

                if (tag == "cube" || tag == "rectangle" || tag == "cylinder" || tag == "sphere")
                {
                    tagShape = tag;
                    print(tagShape);
                };
            });

            matchedIndex = requests.FindIndex(req => (req.Shape == tagShape) && (req.Color == tagColor));

            float randomNum = Random.Range(0, 3);
            if (matchedIndex != -1)
            {
                print(requests[matchedIndex].Time);
                points.GetComponent<PointController>().AddPoints(requests[matchedIndex].Time);
                requests.RemoveAt(matchedIndex);
                switch (randomNum)
                {
                    case 1:
                        requestText.GetComponent<TextMeshPro>().text = "Nice!";
                        break;
                    case 2:
                        requestText.GetComponent<TextMeshPro>().text = "Awesome B)";
                        break;
                    case 0:
                        requestText.GetComponent<TextMeshPro>().text = "GOOD WORK";
                        break;
                    default:
                        requestText.GetComponent<TextMeshPro>().text = "okay";
                        break;
                }
                
                
                StartCoroutine(Correct());
                
            } else
            {
                switch (randomNum)
                {
                    case 1:
                        requestText.GetComponent<TextMeshPro>().text = "are you stupid or something???";
                        break;
                    case 2:
                        requestText.GetComponent<TextMeshPro>().text = "uh oh idiot alert";
                        break;
                    case 0:
                        requestText.GetComponent<TextMeshPro>().text = "no!";
                        break;
                    default:
                        requestText.GetComponent<TextMeshPro>().text = "no";
                        break;
                }
                StartCoroutine(Wrong());
            }

        }
    }
    IEnumerator Correct()
    { 
        yield return new WaitForSecondsRealtime(2);
        requestObj.GetComponent<RequestGenerator>().GenNewShape();
        doneDetecting = true;
        Destroy(gameObject);
    }

    IEnumerator Wrong()
    {
        yield return new WaitForSecondsRealtime(2);
        requestObj.GetComponent<RequestGenerator>().UpdateText();
        doneDetecting = true;
    }
}

