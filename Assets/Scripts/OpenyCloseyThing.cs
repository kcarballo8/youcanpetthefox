using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenyCloseyThing : MonoBehaviour
{
    public GameObject Self;
    public GameObject Door;
    public bool state;
    public float speed, Closed, Open;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
        Self.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
        Door.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void rotateTo(float target, float opcl)
    {
        while (opcl != target)
        {
            opcl += speed;
            Self.transform.rotation = Quaternion.AngleAxis(opcl, Vector3.forward);
        }
    }
    void OnMouseDown()
    {
        if (state)
        {
            state = false;
            rotateTo(Closed, Open);
            Door.gameObject.SetActive(true);
        }
        else
        {
            state = true;
            rotateTo(Open, Closed);
            Door.gameObject.SetActive(false);
        }
    }
}
