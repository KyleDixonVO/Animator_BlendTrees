using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Manager : MonoBehaviour
{
    private InteractionObject NPC1;
    private InteractionObject NPC2;
    private InteractionObject NPC3;
    private InteractionObject NPC4;
    private InteractionObject NPC5;
    private InteractionObject Coin;
    private InteractionObject Carrot;
    private InteractionObject Scroll;
    private InteractionObject Gem;
    private InteractionObject Shovel;
    private InteractionObject GemSign;
    // Start is called before the first frame update
    void Start()
    {
        NPC1 = GameObject.Find("NPC1").GetComponent<InteractionObject>();
        NPC2 = GameObject.Find("NPC2").GetComponent<InteractionObject>();
        NPC3 = GameObject.Find("NPC3").GetComponent<InteractionObject>();
        NPC4 = GameObject.Find("NPC4").GetComponent<InteractionObject>();
        NPC5 = GameObject.Find("NPC5").GetComponent<InteractionObject>();
        Coin = GameObject.Find("Coin").GetComponent<InteractionObject>();
        Carrot = GameObject.Find("Carrot").GetComponent<InteractionObject>();
        Scroll = GameObject.Find("Scroll").GetComponent<InteractionObject>();
        Gem = GameObject.Find("Gem").GetComponent<InteractionObject>();
        Shovel = GameObject.Find("Shovel").GetComponent<InteractionObject>();
        GemSign = GameObject.Find("Gem Sign").GetComponent<InteractionObject>();

    }

    // Update is called once per frame
    void Update()
    {
        CheckConversationStates();
    }

    public void CheckConversationStates()
    {
        //Waterfall Woman
        if (NPC1.initalConvoFinished == false)
        {
            NPC1.currentDialogue = NPC1.firstDialogue;
        }
        else if (Coin.obtained == false)
        {
            NPC1.currentDialogue = NPC1.secondDialogue;
        }
        else
        {
            NPC1.currentDialogue = NPC1.thirdDialogue;
        }


        //Farmer
        if (NPC2.initalConvoFinished == false)
        {
            NPC2.currentDialogue = NPC2.firstDialogue;
        }
        else if (Shovel.obtained == false)
        {
            NPC2.currentDialogue = NPC2.secondDialogue;
        }
        else
        {
            NPC2.currentDialogue = NPC2.thirdDialogue;
        }


        //Guard
        if (NPC3.initalConvoFinished == false)
        {
            NPC3.currentDialogue = NPC3.firstDialogue;
        }
        else if (GemSign.signRead == false)
        {
            NPC3.currentDialogue = NPC3.secondDialogue;
        }
        else
        {
            NPC3.currentDialogue = NPC3.thirdDialogue;
        }


        //Cliff Lady
        if (NPC4.initalConvoFinished == false)
        {
            NPC4.currentDialogue = NPC4.firstDialogue;
        }
        else if (Carrot.obtained == false)
        {
            NPC4.currentDialogue = NPC4.secondDialogue;
        }
        else
        {
            NPC4.currentDialogue = NPC4.thirdDialogue;
        }


        //Kid
        if (NPC5.initalConvoFinished == false)
        {
            NPC5.currentDialogue = NPC5.firstDialogue;
        }
        else
        {
            NPC5.currentDialogue = NPC5.secondDialogue;
        }
    }
}
