using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Talking talking;

    public void TriggerTalking ()
    {
        FindObjectOfType<DialogueManager>().StartTalking(talking);
    }

}
