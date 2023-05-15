using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    FoodSFX effect;

    void Start()
    {
        effect = FindObjectOfType<FoodSFX>();
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreCounter.Score += 1;
            effect.PlayEffect();
            Destroy(gameObject);
        } else if (collision.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }

    
}
