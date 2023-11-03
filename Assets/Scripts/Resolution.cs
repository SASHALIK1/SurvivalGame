using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    public int targetWidth = 1920;
    public int targetHeight = 1080;

    private void Awake()
    {
        Screen.SetResolution(targetWidth, targetHeight, true, targetWidth / targetHeight);      
    }
}
