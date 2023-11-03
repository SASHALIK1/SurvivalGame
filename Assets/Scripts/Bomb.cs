using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject Xplosion;
    public void DestroyObject()
    {
        GameObject newObject = Instantiate(Xplosion, transform.position, Quaternion.identity);
        newObject.SetActive(true);
        Destroy(gameObject);
        
    }
}
