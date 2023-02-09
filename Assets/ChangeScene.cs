using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Application.LoadLevel("Level1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            Application.LoadLevel("Level2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            Application.LoadLevel("Level3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            Application.LoadLevel("WizardHouse");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            Application.LoadLevel("Level4");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            Application.LoadLevel("Transition");
        }
        if (Input.GetKeyDown(KeyCode.Alpha7)) {
            Application.LoadLevel("FinalLevel");
        }
        if (Input.GetKeyDown(KeyCode.Alpha8)) {
            Application.LoadLevel("Ending");
        }
    }
}
