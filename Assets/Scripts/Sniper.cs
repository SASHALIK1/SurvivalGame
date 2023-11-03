using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float followSpeed = 1.0f;
    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            Vector3 movement = direction.normalized * followSpeed * Time.deltaTime;
            transform.position += movement;
        }
    }
}
