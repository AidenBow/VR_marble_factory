using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRedCube : MonoBehaviour
{
    public GameObject RedCubePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCube ()
    {
        GameObject cube = Instantiate(RedCubePrefab);
        cube.transform.position = transform.position;
    }

}
