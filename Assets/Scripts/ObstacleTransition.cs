using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTransition : MonoBehaviour
{
    public int movingSpeed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(movingSpeed*Time.deltaTime,0,0);
    }
}
