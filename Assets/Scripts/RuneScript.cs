using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneScript : MonoBehaviour
{

    public GameObject MagicCircleCenter, Self;
    public float offsetRadius, offsetAngle;
    // Start is called before the first frame update
    void Start()
    {
        Self.transform.position = MagicCircleCenter.transform.position;
        if (offsetAngle == 1)
        {
            Self.transform.position = Vector3.up * offsetRadius;
        }
        else if (offsetAngle == 2)
        {
            Self.transform.position = Vector3.down * offsetRadius;
        }
        else if (offsetAngle == 3)
        {
            Self.transform.position = Vector3.left * offsetRadius;
        }
        else if (offsetAngle == 4)
        {
            Self.transform.position = Vector3.right * offsetRadius;
        }
        Self.transform.rotation = Quaternion.AngleAxis(offsetAngle * 90, Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
       /* if (MagicCircleCenter.activeSelf)
        {
            Self.transform.position = new Vector3(0, offsetRadius, 0);
        }*/
    }
}
