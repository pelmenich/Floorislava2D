using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWinnerSound : MonoBehaviour
{
    public AudioSource sound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
        collision.gameObject.SetActive(false);
    }
}
