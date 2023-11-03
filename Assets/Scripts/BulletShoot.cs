using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public Transform target;
    public GameObject particles;
    [SerializeField] private float moveSpeed = 5.0f;

    private bool hasLookedAtTarget = false;
    private void Awake()
    {
        //target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        if (!hasLookedAtTarget && target != null)
        {
            Vector3 targetDirection = target.position - transform.position;
            float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
            hasLookedAtTarget = true;
        }
        else
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Untagged"))
        {
            GameObject newObject = Instantiate(particles, transform.position, transform.rotation);
            newObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
