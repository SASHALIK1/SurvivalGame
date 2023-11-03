using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SECRET : MonoBehaviour
{
    public float gSpeed = 1f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if(gSpeed >= 0.1f)
            {
                gSpeed -= 0.10f;
                Time.timeScale = gSpeed;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            gSpeed += 0.25f;
            Time.timeScale = gSpeed;
        }
    }
}
