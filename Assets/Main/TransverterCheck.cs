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
                    gameObject.transform.localScale = new Vector3(0.05f, 0.02f, 0.1f);
                    break;
                case "cylinder":
                    GetComponent<MeshFilter>().mesh = cylinder;
                    Destroy(GetComponent<BoxCollider>());
                    Destroy(GetComponent<SphereCollider>());
                    if (GetComponent<CapsuleCollider>() == null)
                    {
                        gameObject.AddComponent<CapsuleCollider>();
                    }
                    break;
                default:
                    Debug.Log("error: default case activated");
                    break;
            }
            
            
        }
    }
}
