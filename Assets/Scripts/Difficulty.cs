using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    private int i = 0;
    public GameObject[] dangs;
    public GameObject[] dangsWarn;
    void Start()
    {
        StartCoroutine(difficulty());
    }
    public IEnumerator difficulty()
    {
        dangs[i].SetActive(true);
        dangsWarn[i].SetActive(true);
        yield return new WaitForSeconds(20);
        i++;
        if(i != 8)
        {
            StartCoroutine(difficulty());
        }        
    }
}
