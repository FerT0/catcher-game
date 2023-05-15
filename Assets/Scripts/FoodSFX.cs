using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSFX : MonoBehaviour
{
    public AudioClip clip;

    public void PlayEffect()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
