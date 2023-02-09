using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed*Time.deltaTime,0,0);
        if (transform.position.x <= -13.5) {
            transform.position = new Vector3(13.5f, transform.position.y, 0f);
        }
    }
}
