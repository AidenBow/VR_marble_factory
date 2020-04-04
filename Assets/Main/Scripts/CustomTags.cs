using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTags : MonoBehaviour
{
    public List<string> tags;
    void Start()
    {
        AddTag("cube");
        AddTag("red");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTag(string tag)
    {
        tags.Add(tag);
    }

    public void ResetShapeTags()
    {
        tags.Remove("cube");
        tags.Remove("rectangle");
        tags.Remove("sphere");
        tags.Remove("cylinder");
    }
}
