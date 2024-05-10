using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBalls : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    private void OnTriggerEnter(Collider other)
    {
        if (Collision.Equals(other.gameObject.CompareTag("Knife"), this.gameObject))
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            Destroy(this.gameObject);
        }
        audioSource.Play();
    }
}
