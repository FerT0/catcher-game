using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSFX : MonoBehaviour
{
    public AudioClip clip;

    public void PlayEffect()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
