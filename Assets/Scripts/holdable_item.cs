using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdable_item : MonoBehaviour
{
    public GameObject Self, Player, hold, held;
    public float holdPosition;
    private Vector3 sitpos;

    // Start is called before the first frame update
    void Start()
    {
        held.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (held.activeSelf)
        {
            Self.transform.position = hold.transform.position; 
        }
    }
}
