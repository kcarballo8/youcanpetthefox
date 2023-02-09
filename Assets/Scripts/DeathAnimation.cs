using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    public GameObject wizard;
    public GameObject fox;

    private int health = 5;
    bool trigger = false;

    private void Start()
    {
        fox.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z) && trigger) {
            health--;
        }

        if (health <= 0)
        {
            Destroy(wizard);
        }
        if (health <= 1)
        {
            fox.SetActive(true);
        }
    }
}
