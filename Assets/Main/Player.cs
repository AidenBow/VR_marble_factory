using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Input_Sources handType;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool triggerActive = SteamVR_Actions.default_GrabGrip.GetState(handType);

        if (triggerActive)
        {
            Debug.Log("grip");
        }
    }
}
