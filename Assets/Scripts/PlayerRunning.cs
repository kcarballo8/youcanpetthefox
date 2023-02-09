using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunning : MonoBehaviour
{
    public bool IJ;
    public int jumpHeight = 12;
    // Start is called before the first frame update
    void Start()
    {
        IJ = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && IJ == false) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpHeight, 0);
            IJ = true;
        }
        
    }

    void OnCollisionEnter2D(Collision2D Coll) {
        if (Coll.gameObject.tag == "Finish") {
            IJ = false;
        }

        if (Coll.gameObject.tag == "Respawn") {
            Application.LoadLevel("Transition");
        }
       
         }
}
