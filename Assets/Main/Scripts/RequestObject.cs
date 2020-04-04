using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestObject : MonoBehaviour
{
    public string Shape { get; set; }
    public string Color { get; set; }
    public float Time { get; set; }
    //public bool Equals(RequestObject other)
    //{
    //    if (other == null) return false;
    //    return (this.Color.Equals(other.Color) && this.Shape.Equals(other.Shape));
    //}

    //public RequestObject(string shape, string color, float time)
    //{
    //    Shape = shape;
    //    Color = color;
    //    Time = time;
    //}
}
