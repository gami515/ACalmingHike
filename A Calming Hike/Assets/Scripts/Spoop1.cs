using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoop1 : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Spoop Activated");
        audioSource.Play();
        Destroy(gameObject);
    }
}
