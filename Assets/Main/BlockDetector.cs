using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class BlockDetector : MonoBehaviour
{
    public GameObject requestObj;
    public GameObject requestText;
    public bool doneDetecting = true;
    void Start()
    {
        requestObj = GameObject.Find("/RequestGenerator");
        requestText = GameObject.Find("/RequestGenerator/RequestText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "placemat" && doneDetecting)
        {
            doneDetecting = false;
            float randomNum = Random.Range(0, 3);
            List<string> tags = gameObject.GetComponent<CustomTags>().tags;
            List<string> requests = requestObj.GetComponent<RequestGenerator>().requests;
            bool hasMatch = tags.Select(i => i.ToString()).Intersect(requests).Any();
            
            if (hasMatch)
            {
                print(hasMatch + " match");
                tags.ForEach(delegate (string tag)
                {
                    Debug.Log(requests.Find(req => req.Contains(tag)));
                    requests.Remove(requests.Find(req => req.Contains(tag)));
                    
                });
                    

                
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
