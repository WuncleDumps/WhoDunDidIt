using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    private Queue<string> sentences;

   void Start(){
        sentences = new Queue<string>();
   }

    void Update(){

        if(Input.GetKeyDown(KeyCode.F)){
            DisplayNextSentence();
        }
    }

   public void StartDialogue(Dialogue dialogue)
   {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences) 
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
   }

   public void DisplayNextSentence()
   {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
   }

   void EndDialogue()
   {
        animator.SetBool("IsOpen",false);
   }
}
