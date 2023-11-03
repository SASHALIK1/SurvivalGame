using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCannon : MonoBehaviour
{
    public GameObject[] Laser;
    private void Awake()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        Laser[0].SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Laser[0].SetActive(false);
        yield return new WaitForSeconds(0.1f);
        Laser[1].SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Laser[1].SetActive(false);
        yield return new WaitForSeconds(0.1f);
        Laser[2].SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Laser[2].SetActive(false);
        yield return new WaitForSeconds(0.1f);
        Laser[3].SetActive(true);
        yield return new WaitForSeconds(1f);
        Laser[3].SetActive(false);
        yield return new WaitForSeconds(3f);
        StartCoroutine(Shoot());
    }
}
