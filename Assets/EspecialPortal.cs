using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspecialPortal : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            Debug.Log("Player collided!");
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }

}
