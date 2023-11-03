using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombing : MonoBehaviour
{
    [SerializeField] private GameObject WarningSpawn;
    [SerializeField] private GameObject BombSpawn;
    [SerializeField] private Vector2 spawnRangeMax = new Vector2(7f, 3f);
    [SerializeField] private Vector2 spawnRangeMin = new Vector2(-4f, -3.69f);
    private void Awake()
    {
        StartCoroutine(Shoot());
    }
    private void SpawnRandomObject()
    {
        float randomX = Random.Range(spawnRangeMin.x, spawnRangeMax.x);
        float randomY = Random.Range(spawnRangeMin.y, spawnRangeMax.y);
        Vector2 randomPosition = new Vector2(randomX, randomY);
        GameObject newObject = Instantiate(WarningSpawn, randomPosition, Quaternion.identity);
        newObject.SetActive(true);
        GameObject newerObject = Instantiate(BombSpawn, randomPosition, Quaternion.identity);
        newerObject.SetActive(true);
    }
    IEnumerator Shoot()
    {      
        yield return new WaitForSeconds(5f);        
        StartCoroutine(Shoot());
        SpawnRandomObject();
    }
    
}
