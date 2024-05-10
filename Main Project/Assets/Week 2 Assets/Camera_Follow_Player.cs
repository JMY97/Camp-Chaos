using UnityEngine;

public class Camera_Follow_Player : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = target.position;
    }
}
