using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(dest());
    }
    IEnumerator dest()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}
