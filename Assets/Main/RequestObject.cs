using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestObject : MonoBehaviour
{
    public string Shape { get; set; }
    public string Color { get; set; }
    public int Time { get; set; }
    public RequestObject(string shape, string color, int time)
    {
        Shape = shape;
        Color = color;
        Time = time;
    }
}
