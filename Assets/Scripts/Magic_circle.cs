using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_circle : MonoBehaviour
{
    public GameObject center;
    public float cosmicRotation, cosmicSpeed;

    private Quaternion rotation;
    private bool rotateOn;

    // Start is called before the first frame update
    void Start()
    {
        rotateOn = true;
        center.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        rotation = Quaternion.AngleAxis(cosmicSpeed, Vector3.forward);
        RotateMagicCircle(rotation);
    }

    void RotateMagicCircle(Quaternion rotat)
    {
        if (rotateOn)
        {
            center.transform.rotation *= rotat;
        }
    }

    void OnMouseDown()
    {
        if (rotateOn)
        {
            rotateOn = false;
            center.gameObject.SetActive(false);
        }
        else
        {
            rotateOn = true;
            center.gameObject.SetActive(true);
        }
    }

}
    
