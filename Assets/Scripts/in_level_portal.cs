using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class in_level_portal : MonoBehaviour
{
    public GameObject OtherEnd, ThisEnd, Player, justTeleported;
    public int step = 1;
    private CircleCollider2D thisCollider, otherCollider;
    private Collider2D playerCollider;

    protected virtual void Start()
    {
        thisCollider = ThisEnd.GetComponent<CircleCollider2D>();
        otherCollider = OtherEnd.GetComponent<CircleCollider2D>();
        playerCollider = Player.GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        if (justTeleported.activeSelf)
        {
            if (thisCollider.IsTouching(playerCollider))
            {
                Player.transform.position = ThisEnd.transform.position;
                for (int i = 0; i < 360 / step; i += step)
                {
                    ThisEnd.transform.rotation = Quaternion.AngleAxis(i, Vector3.forward);
                }
                Player.transform.position = OtherEnd.transform.position;
                justTeleported.SetActive(false);
                //OtherEnd.SetActive(false);
                //ThisEnd.SetActive(false);
            }
        }
        else if (!touching())
        {
            justTeleported.SetActive(true);
        }
    }

    bool touching()
    {
        return (thisCollider.IsTouching(playerCollider) || otherCollider.IsTouching(playerCollider));
    }
}
