using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBalls : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    int random_int;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            random_int = Random.Range(-2, 2);
            offset = new Vector3(random_int, 0, 0);
            Instantiate(ball, transform.position + offset, transform.rotation);
        }
    }
}
