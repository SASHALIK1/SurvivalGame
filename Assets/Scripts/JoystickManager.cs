using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickManager : MonoBehaviour
{
    public Joy FixedJoy;
    public GameObject Tick;
    private void Awake()
    {
        if (FixedJoy.FixedJoy)
        {            
            Tick.SetActive(true);
        }
        else
        {
            Tick.SetActive(false);
        }
    }
    public void ChangeTick()
    {
        if (FixedJoy.FixedJoy)
        {
            FixedJoy.FixedJoy = false;
            Tick.SetActive(false);
        }
        else
        {
            FixedJoy.FixedJoy = true;
            Tick.SetActive(true);
        }
    }
}
