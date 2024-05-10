using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();  
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
            anim.Play("Jump", -1, 0f);
        if (Input.GetKeyDown("2"))
            anim.Play("Reload", -1, 0f);
        if (Input.GetKeyDown("3"))
            anim.Play("Run_guard_AR", -1, 0f);
        if (Input.GetKeyDown("4"))
            anim.Play("Shoot_Autoshot_AR", -1, 0f);
        if (Input.GetKeyDown("5"))
            anim.Play("WalkBack_Shoot_AR", -1, 0f);
    }
}
