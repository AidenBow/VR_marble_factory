using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public string selectedShape; 
    void Start()
    {
        //transverter.selectedShape = "cylinder";
        selectedShape = "sphere";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Rectangle")
        {
            print("rec");
            selectedShape = "rectangle";
        } else if (other.transform.name == "Cylinder")
        {
            print("cyl");
            selectedShape = "cylinder";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("sphere");
        selectedShape = "sphere";
    }
}
