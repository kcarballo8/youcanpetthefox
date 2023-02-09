using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRock : MonoBehaviour
{
    public GameObject rock;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            rock.transform.position = new Vector3((float)-11.5, (float)15.5, 0);
            Destroy(this);
        }
    }
}
