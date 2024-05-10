using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    Ray myRay;
    RaycastHit hit;
    public GameObject dart;

    void Update()
    {
        myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(myRay, out hit))
        {
            Debug.DrawLine(myRay.origin, hit.point, Color.red);

            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.tag == "Target")
                    Destroy(hit.collider.gameObject);
                else
                    Instantiate(dart, hit.point, Quaternion.identity);
            }
        }
        else
            Debug.DrawLine(myRay.origin, myRay.origin + myRay.direction * 100, Color.green);
    }
}
