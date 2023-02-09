using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject nameText;
    public GameObject dialogueText;
    public GameObject DiaBack;
    public GameObject DiaFront;
    public GameObject Interacto;
    string name;
    public int strings;
    public int cares;
    
    private Queue<string> sentences;
    private Queue<string> dontcares;

    // init
    void Start()
    {
        
        
        sentences = new Queue<string>();
        dontcares = new Queue<string>();
        DiaBack.SetActive(false);
        DiaFront.SetActive(false);
        nameText.SetActive(false);
        dialogueText.SetActive(false);
        Interacto.SetActive(false);
    }

    public void StartDialogue (Dialogue dialogue)
    {
        
        Debug.Log("starting dialogue with " + dialogue.name);
        name = dialogue.name;
        Interacto.SetActive(true);
        sentences.Clear();
        dontcares.Clear();
       
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence); 

        }
        foreach (string dontcare in dialogue.carelesses)
        {
            dontcares.Enqueue(dontcare);
        }    
        strings = sentences.Count;
        cares = dontcares.Count;
       

    }
    public void DisplayNextSentence ()
    {
        Interacto.SetActive(false);
        DiaBack.SetActive(true);
        DiaFront.SetActive(true);
        nameText.SetActive(true);
        dialogueText.SetActive(true);
        nameText.GetComponent<Text>().text = name;
        
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }


        if (FindObjectOfType<DialogueTrigger>().dontcare == true)
        {
            Debug.Log("YAYYAYYAYAYY");
            string careless = dontcares.Dequeue();
            dialogueText.GetComponent<Text>().text = careless;
            cares = dontcares.Count;
        }
        else
        {
            string sentence = sentences.Dequeue();
            dialogueText.GetComponent<Text>().text = sentence;
            strings = sentences.Count;
        }
    }

    
    

    public void EndDialogue()
    {
        
        DiaBack.SetActive(false);
        DiaFront.SetActive(false);
        nameText.SetActive(false);
        dialogueText.SetActive(false);
        Interacto.SetActive(false);
        Debug.Log("End of conversation. *mic drop*");
        cares = 0;
    }
}
