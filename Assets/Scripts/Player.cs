using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    //public Transform myPos;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        var fox = GameObject.FindGameObjectWithTag("Fox");
        if (fox != null && Input.GetKey(KeyCode.Space)) {
            animator.SetTrigger("PetTheFox");
            // animator.Play("Pet_Fox");
            StartCoroutine(waiter(fox));
        }
    }

    IEnumerator waiter(GameObject fox) {
        fox.SetActive(false);
        yield return new WaitForSeconds(0.75f);
        fox.SetActive(true);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    

    // private void Start(){
    //     //if (playerScenes.myPos2.x != 0 && playerScenes.myPos2.y != 0 && playerScenes.myPos2.z != 0)
    //         myPos.position = playerScenes.myPos2;
    // }

}
