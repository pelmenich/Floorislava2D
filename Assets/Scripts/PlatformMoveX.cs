using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveX : MonoBehaviour
{
    public float speed;
    public int startPoint = 0;
    public Transform[] points;
    // Update is called once per frame
    private int i = 0;
    private void Start()
    {
        transform.position = points[startPoint].position;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i = i == points.Length-1 ? 0 : ++i;
            
        }
        transform.position = Vector2.MoveTowards(
                                        transform.position,
                                        points[i].position,
                                        speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        other.transform.SetParent(null);
    }
}
