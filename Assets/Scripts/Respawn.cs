using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public AudioSource sound;
    private Vector2 spawnPoint = new Vector2(-10.5f, 0.53f);
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sound.Play();
        Teleport();
    }

    void Teleport()
    {
        player.transform.position = spawnPoint;
    }
}
