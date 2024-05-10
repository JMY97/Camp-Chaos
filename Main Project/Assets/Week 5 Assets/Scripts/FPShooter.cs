using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FPShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Camera playerCamera;

    public AudioSource audioSource;
    public AudioClip shootClip;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(shootClip);

            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position =  playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.localRotation = playerCamera.transform.rotation;

            bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.localRotation = playerCamera.transform.rotation;

            bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.localRotation = playerCamera.transform.rotation;

           

        }
    }
}
