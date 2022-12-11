using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    private Queue<string> sentences;

    //Use this for initialization

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartTalking (Talking talking)
    {
        sentences.Clear();
        foreach (string sentence in talking.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
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

    }
       
}
