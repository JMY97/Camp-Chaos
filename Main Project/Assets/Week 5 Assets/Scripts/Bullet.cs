using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public float lifeDuration = 0.5f;
    public AudioSource audioSource;
    public AudioClip impactSound;

     void Update()
    {
        transform.position += transform.forward * speed;
        lifeDuration -= Time.deltaTime;
        if (lifeDuration <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie")){
            Destroy(this.gameObject);
            audioSource.PlayOneShot(impactSound);
        }
        //audioSource.PlayOneShot(impactSound);
    }


}
