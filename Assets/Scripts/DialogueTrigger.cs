using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    bool triggered = false;
    public bool dontcare = false;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Z) && triggered)
        {
            
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
            if (FindObjectOfType<DialogueManager>().cares == 0)
            {
                dontcare = false;
            }
            
        }
    }
    public void TriggerDialogue()
    {      
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        triggered = true;
        if (other.tag == "Player")
        {
            TriggerDialogue();
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        triggered = false;
        FindObjectOfType<DialogueManager>().EndDialogue();
        if (FindObjectOfType<DialogueManager>().strings != 0)
        {
            Debug.Log("Exited interactible space prematurely. Testing for dontcare()...");
            dontcare = true;
            
        }
    }
}
