using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject Barricade;
    public float startGeneratingAfterThisManySeconds = 0.5f;
    public float generateAfterEveryManySeconds = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createNew",startGeneratingAfterThisManySeconds,generateAfterEveryManySeconds);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createNew() {
        Spawn = Instantiate(Barricade,transform.position,Quaternion.identity) as GameObject; 
    }
}
