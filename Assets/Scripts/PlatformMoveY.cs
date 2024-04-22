using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveY : MonoBehaviour
{
    private bool isPosDirection = true;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posY = transform.position.y;
        if (posY <= -1.5f || posY >= 0.5f)
            ToggleDirection();
        float move = isPosDirection ? 0.03f : -0.03f;
        transform.position += new Vector3(0f, move, 0f);
    }

    void ToggleDirection()
    {
        isPosDirection = !isPosDirection;
    }
}
