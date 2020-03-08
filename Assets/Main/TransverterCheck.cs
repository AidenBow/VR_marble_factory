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
                    gameObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
                    Destroy(GetComponent<BoxCollider>());
                    Destroy(GetComponent<CapsuleCollider>());
                    if (GetComponent<SphereCollider>() == null)
                    {
                        gameObject.AddComponent<SphereCollider>();
                    }
                    GetComponent<CustomTags>().ResetShapeTags();
                    GetComponent<CustomTags>().AddTag("sphere");
                    break;

                case "rectangle":
                    GetComponent<MeshFilter>().mesh = cube;
                    gameObject.transform.localScale = new Vector3(0.05f, 0.02f, 0.1f);
                    Destroy(GetComponent<CapsuleCollider>());
                    Destroy(GetComponent<SphereCollider>());
                    if (GetComponent<BoxCollider>() == null)
                    {
                        gameObject.AddComponent<BoxCollider>();
                    }
                    GetComponent<CustomTags>().ResetShapeTags();
                    GetComponent<CustomTags>().AddTag("rectangle");
                    break;

                case "cylinder":
                    GetComponent<MeshFilter>().mesh = cylinder;
                    gameObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
                    Destroy(GetComponent<BoxCollider>());
                    Destroy(GetComponent<SphereCollider>());
                    if (GetComponent<CapsuleCollider>() == null)
                    {
                        gameObject.AddComponent<CapsuleCollider>();
                    }
                    GetComponent<CustomTags>().ResetShapeTags();
                    GetComponent<CustomTags>().AddTag("cylinder");
                    break;

                default:
                    Debug.Log("error: default case activated");
                    break;
            }
            
            
        }
    }

    private void OnTriggerExit(Collider other) //for when play changes lever while objects inside
    {
        if (other.transform.name == "Inside")
        {
            switch (lever.GetComponent<Lever>().selectedShape)
            {
                case "sphere":
                    GetComponent<MeshFilter>().mesh = sphere;
                    gameObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
                    Destroy(GetComponent<BoxCollider>());
                    Destroy(GetComponent<CapsuleCollider>());
                    if (GetComponent<SphereCollider>() == null)
                    {
                        gameObject.AddComponent<SphereCollider>();
                    }
                    GetComponent<CustomTags>().ResetShapeTags();
                    GetComponent<CustomTags>().AddTag("sphere");
                    break;

                case "rectangle":
                    GetComponent<MeshFilter>().mesh = cube;
                    gameObject.transform.localScale = new Vector3(0.05f, 0.02f, 0.1f);
                    Destroy(GetComponent<CapsuleCollider>());
                    Destroy(GetComponent<SphereCollider>());
                    if (GetComponent<BoxCollider>() == null)
                    {
                        gameObject.AddComponent<BoxCollider>();
                    }
                    GetComponent<CustomTags>().ResetShapeTags();
                    GetComponent<CustomTags>().AddTag("rectangle");
                    break;

                case "cylinder":
                    GetComponent<MeshFilter>().mesh = cylinder;
                    gameObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
                    Destroy(GetComponent<BoxCollider>());
                    Destroy(GetComponent<SphereCollider>());
                    if (GetComponent<CapsuleCollider>() == null)
                    {
                        gameObject.AddComponent<CapsuleCollider>();
                    }
                    GetComponent<CustomTags>().ResetShapeTags();
                    GetComponent<CustomTags>().AddTag("cylinder");
                    break;

                default:
                    Debug.Log("error: default case activated");
                    break;
            }


        }
    }
}
