using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransverterCheck : MonoBehaviour
{
    public Mesh cube;
    public Mesh sphere;
    
    void Start()
    {
        cube = GetComponent<MeshFilter>().mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Inside")
        {
            
            GetComponent<MeshFilter>().mesh = sphere;
            Destroy(GetComponent<BoxCollider>());
            if (GetComponent<SphereCollider>() == null)
            {
                gameObject.AddComponent<SphereCollider>();
            }
            
        }
    }
}
