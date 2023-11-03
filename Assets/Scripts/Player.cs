using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public FixedJoystick mobil;
    public GameObject part;
    public GameObject sprt;
    public float moveSpeed = 5.0f; 
    private Rigidbody2D rb;
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {       
        movement.x = mobil.Horizontal;  
        if(mobil.Horizontal == 0)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
        }
        movement.y = mobil.Vertical;
        if (mobil.Vertical == 0)
        {
            movement.y = Input.GetAxisRaw("Vertical");
        }
    
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Danger"))
        {
            part.SetActive(true);
            sprt.SetActive(false);
            Debug.Log("You Died");
            StartCoroutine(deder());
        }
    }
    public IEnumerator deder()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("DED");
    }
}
