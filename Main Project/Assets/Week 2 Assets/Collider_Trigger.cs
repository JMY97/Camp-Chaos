using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Trigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " is in OnCollisionEnter state with " + collision.gameObject.name);
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log(gameObject.name + " is in OnCollisionStay state with " + collision.gameObject.name);
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log(gameObject.name + " is in OnCollisionExit state with " + collision.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " is in OnTriggerEnter state with " + other.gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log(gameObject.name + " is in OnTriggerStay state with " + other.gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log(gameObject.name + " is in OnTriggerExit state with " + other.gameObject.name);
    }
}
