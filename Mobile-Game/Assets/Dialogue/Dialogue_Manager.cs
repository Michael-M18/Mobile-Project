using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue_Manager : MonoBehaviour
{

    public NPC npc;
    private bool canTalk = false;
    bool isTalking = false;


    float distance;
    int curResponseTracker = 0;

    public GameObject player;
    public GameObject dialogueUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;

    public Button choice1;
    public Button choice2;
    public Button choice3;

    public Text choice1Text;
    public Text choice2Text;
    public Text choice3Text;

    private void Start()
    {
        dialogueUI.SetActive(false);
        canTalk = false;
    }

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance <= 2.5f)
        {
            if (Input.GetKeyDown("e") && isTalking == false)

            {
                StartConversation();
            }
            else if (Input.GetKeyDown(KeyCode.E) && isTalking == true)

            {
                EndDialogue();
            }
        }
    }
    /*
    private void OnTriggerEnter()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance <= 2.5f)
        {
            Debug.Log("Close enough");
            //trigger dialogue
            canTalk = true;
        }
    }
    */
    void StartConversation()

    {
        isTalking = true;
        curResponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        curResponseTracker = 0;
        npcDialogueBox.text = npc.dialogue[0];
        choice1Text.text = npc.playerDialogue[0];
        choice2Text.text = npc.playerDialogue[1];
        choice3Text.text = npc.playerDialogue[2];
    }

    void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }

    public void ChoiceClick()
    {
        curResponseTracker++;
        npcDialogueBox.text = npc.dialogue[curResponseTracker];
    }




}
