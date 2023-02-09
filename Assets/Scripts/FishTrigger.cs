using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishTrigger : MonoBehaviour
{
    bool triggered = false;
    
    public GameObject Fishing;
    public GameObject Prompt;
    

    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.F) && triggered)
        {
            Fishing.SetActive(true);
            Prompt.SetActive(false);
        }
    }
  
    void OnTriggerEnter2D(Collider2D other)
    {
        triggered = true;
        if (other.tag == "Player")
        {
            Prompt.SetActive(true);
            Prompt.GetComponent<Text>().text = "Press F to Fish";
        }
        

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        triggered = false;
       
        
            Fishing.SetActive(false);
        Prompt.GetComponent<Text>().text = "Press Z to Interact";
    }
}
