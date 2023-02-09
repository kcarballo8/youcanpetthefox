using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdable_switch : MonoBehaviour
{
    public GameObject held;
    void OnMouseDown()
    {
        if (held.activeSelf)
        {
            held.SetActive(false);
        }
        else
        {
            held.SetActive(true);
        }
    }
}
