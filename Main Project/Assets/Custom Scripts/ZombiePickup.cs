using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePickup : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip pickupClip;
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.CompareTag("Knife"))
        { 
            audioSource.PlayOneShot(pickupClip);
            Destroy(other.gameObject);
            //audioSource.PlayOneShot(pickupClip);
        }
    }
}
