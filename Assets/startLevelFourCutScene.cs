using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startLevelFourCutScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            Debug.Log("hey");
        }
    }
}
