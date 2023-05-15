using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCollision : MonoBehaviour
{
    StoneSFX effect;

    void Start()
    {
        effect = FindObjectOfType<StoneSFX>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerLives.Lives -= 1;
            effect.PlayEffect();
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }

}
