using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryTurret : MonoBehaviour
{
    public GameObject Bullet;
    AudioSource sorc;
    private void Awake()
    {
        StartCoroutine(Shoot());
        sorc = gameObject.GetComponent<AudioSource>();
    }
    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(2f);
        GameObject newObject = Instantiate(Bullet, transform.position, Quaternion.identity);
        newObject.SetActive(true);
        StartCoroutine(Shoot());
        sorc.Play();
    }
}

