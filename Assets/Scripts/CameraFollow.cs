using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
    public Transform target;
    public Vector3 offset; 

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;

            transform.position = new Vector3(desiredPosition.x, desiredPosition.y, transform.position.z);
        }
    }
}
