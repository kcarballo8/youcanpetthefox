using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    private GameObject[] rocks;
    private bool isFilled = false;

    private void Start()
    {
        rocks = GameObject.FindGameObjectsWithTag("Rock");
        foreach (GameObject rock in rocks)
        {
            Physics2D.IgnoreCollision(rock.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rock" && !isFilled)
        {
            Destroy(collision.gameObject);
            ChangeSprite();
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            isFilled = true;
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
