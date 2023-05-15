using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
    
{
    public Transform[] spawnPoints;
    public GameObject[] foodPrefabs;
    

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            int randFood = Random.Range(0, foodPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            GameObject foodObj = Instantiate(foodPrefabs[randFood], spawnPoints[randSpawnPoint].position, transform.rotation);
            foodObj.tag = "Food";
            foodObj.AddComponent<Rigidbody>();
            foodObj.AddComponent<BoxCollider>();
            foodObj.GetComponent<BoxCollider>().isTrigger = true;
            foodObj.AddComponent<FoodCollision>();
            foodObj.AddComponent<CustomGravity>();
            yield return new WaitForSeconds(1);
            
        }

    }

}


