using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointController : MonoBehaviour
{
    public GameObject pointsText;
    public GameObject newPointsText;
    public float totalPoints;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(float points)
    {
        float calculatedPoints = points / 2 + 10;
        totalPoints += calculatedPoints;
        newPointsText.GetComponent<TextMeshPro>().text = "+" + calculatedPoints.ToString("0");
        pointsText.GetComponent<TextMeshPro>().text = "Points: " + totalPoints.ToString("0");
        StartCoroutine(ResetNewPoints());
    }

    IEnumerator ResetNewPoints()
    {
        yield return new WaitForSecondsRealtime(2);
        newPointsText.GetComponent<TextMeshPro>().text = "";
    }
}
