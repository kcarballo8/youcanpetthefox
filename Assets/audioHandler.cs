using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioHandler : MonoBehaviour
{
    public AudioSource audioPlayer;

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "BeastAudioTag") {
            audioPlayer.Play();
            Application.LoadLevel("LeavingFoxScene");
        }
    }
}
