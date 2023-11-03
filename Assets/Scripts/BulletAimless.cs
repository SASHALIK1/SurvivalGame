using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAimless : MonoBehaviour
{
    public float moveSpeed = 5.0f;     
    public float moveAngle = 45.0f;
    public GameObject particles;

    private void Update()
    {
        float radians = moveAngle * Mathf.Deg2Rad;
        float horizontal = Mathf.Cos(radians);
        float vertical = Mathf.Sin(radians);
        Vector3 movement = new Vector3(horizontal, vertical, 0);
        movement = movement.normalized * moveSpeed;
        transform.Translate(movement * Time.deltaTime);
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
