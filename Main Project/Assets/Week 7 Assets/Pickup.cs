using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip pickupClip;
    //GameManager gameManager;

    //public AudioSource ZomAudioSource;
    //public AudioClip ZombieKillClip;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Book") && this.gameObject)
        {
            Destroy(other.gameObject);
            audioSource.PlayOneShot(pickupClip);
        }

        if (other.gameObject.CompareTag("Zombie") && this.gameObject.CompareTag("Knife"))
        {
            Destroy(other.gameObject);
            //gameManager.IncreaseKills();
            //gameManager.KillCheck();
            //ZomAudioSource.PlayOneShot(ZombieKillClip);
        }

    }
}
