using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BlockDetector : MonoBehaviour
{
    public GameObject requestObj;
    public GameObject requestText;
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
        if (other.transform.name == "placemat")
        {
            if (gameObject.GetComponent<CustomTags>().tags.Contains(requestObj.GetComponent<RequestGenerator>().request))
            {
                requestText.GetComponent<TextMeshPro>().text = "Nice!";
                StartCoroutine(Correct());
                
            } else
            {
                requestText.GetComponent<TextMeshPro>().text = "are you stupid or something???";
                StartCoroutine(Wrong());
            }

        }
    }
    IEnumerator Correct()
    { 
        yield return new WaitForSecondsRealtime(2);
        requestObj.GetComponent<RequestGenerator>().GenNewShape();
        Destroy(gameObject);
    }

    IEnumerator Wrong()
    {
        yield return new WaitForSecondsRealtime(2);
        requestText.GetComponent<TextMeshPro>().text = requestObj.GetComponent<RequestGenerator>().request;
    }
}
