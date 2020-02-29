using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDown : MonoBehaviour
{
    public SpawnRedCube spawnRedCube;
    public void ButtonPress()
    {
        spawnRedCube.SpawnCube();
        Debug.Log("button down");
    }
}
