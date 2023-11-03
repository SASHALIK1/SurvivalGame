using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private GameObject player;
    public GameObject Bullet;
    AudioSource sorc;

    // Update is called once per frame
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(Shoot());
        sorc = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (player != null)
        {
            Vector3 targetDirection = player.transform.position - transform.position;
            float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(1f);
        GameObject newObject = Instantiate(Bullet, transform.position, Quaternion.identity);
        newObject.SetActive(true);
        StartCoroutine(Shoot());
        sorc.Play();
    }
}
