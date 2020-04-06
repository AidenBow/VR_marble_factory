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

    public void ResetColorTags()
    {
        tags.Remove("orange");
        tags.Remove("red");
        tags.Remove("yellow");
        tags.Remove("blue");
        tags.Remove("green");
    }
}
