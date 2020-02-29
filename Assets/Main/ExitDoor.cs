using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public Vector3 closedPosition;
    public Vector3 closedRotation;
    public Vector3 openPosition;
    public Vector3 openRotation;
    public bool closed = true;
    void Start()
    {
        closedPosition = gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (closed)
        {
            gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, closedPosition, Time.deltaTime);
            gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, Quaternion.Euler(closedRotation), Time.deltaTime);
        } else
        {
            gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, openPosition, Time.deltaTime);
            gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, Quaternion.Euler(openRotation), Time.deltaTime);
        }
        
    }

    public void ToggleExitDoor()
    {
        if (closed)
        {
            closed = false;
        } else
        {
            closed = true;
        }
    }
}
