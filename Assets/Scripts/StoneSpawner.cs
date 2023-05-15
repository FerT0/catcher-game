using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject stonePrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            int randSpawnTime = Random.Range(2, 8);
            yield return new WaitForSeconds(randSpawnTime);
            GameObject stoneObj = Instantiate(stonePrefab, spawnPoints[randSpawnPoint].position, transform.rotation);
            stoneObj.tag = "Stone";
            stoneObj.AddComponent<Rigidbody>();
            stoneObj.AddComponent<BoxCollider>();
            stoneObj.GetComponent<BoxCollider>().isTrigger = true;
            stoneObj.AddComponent<StoneCollision>();
            stoneObj.AddComponent<CustomGravity>();

        }

    }
}
