using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransverterCheck : MonoBehaviour
{
    public Mesh cube;
    public Mesh sphere;
    public Mesh rectangle;
    public Mesh cylinder;
    public GameObject lever;

    private void Start()
    {
        lever = GameObject.Find("/Lever/Handle");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Inside")
        {
            switch (lever.GetComponent<Lever>().selectedShape)
            {
                case "sphere":
                    GetComponent<MeshFilter>().mesh = sphere;
                    Destroy(GetComponent<BoxCollider>());
                    if (GetComponent<SphereCollider>() == null)
                    {
                        gameObject.AddComponent<SphereCollider>();
                    }
                    break;
                case "rectangle":
                    GetComponent<MeshFilter>().mesh = cube;
                    break;
                case "cylinder":
                    GetComponent<MeshFilter>().mesh = cylinder;
                    break;
                default:
                    Debug.Log("error: default case activated");
                    break;
            }
            
            
        }
    }
}
