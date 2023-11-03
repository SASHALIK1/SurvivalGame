using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partDes : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Des());
    }
    IEnumerator Des()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
