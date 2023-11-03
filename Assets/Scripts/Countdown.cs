using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    private int countdown = 181;
    private TextMeshPro textCount;

    void Start()
    {
        InvokeRepeating("Count", 0.0f, 1.0f);
        textCount = gameObject.GetComponent<TextMeshPro>();
    }
    void Count()
    {
        countdown--;
        textCount.text = countdown.ToString();
        if (countdown == -1)
        {
            SceneManager.LoadScene("win");
        }
    }
}
