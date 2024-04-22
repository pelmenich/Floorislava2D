using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D rb;
    public float movespeed;
    float jumpAmount = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && rb.IsTouchingLayers())
            rb.velocity = new Vector2(rb.velocity.x, jumpAmount);
    }
}
