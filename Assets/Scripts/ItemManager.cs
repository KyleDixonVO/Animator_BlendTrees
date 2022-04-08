using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private InteractionObject Coin;
    private InteractionObject Shovel;
    private InteractionObject Carrot;
    private InteractionObject Scroll;
    private InteractionObject GemSign;
    private InteractionObject Gem;
    private InteractionObject NPC1;
    private InteractionObject NPC2;
    private InteractionObject NPC3;
    private InteractionObject NPC4;
    private InteractionObject NPC5;
    public SceneSwitcher sceneSwitcher;
    // Start is called before the first frame update
    void Start()
    {
        NPC1 = GameObject.Find("NPC1").GetComponent<InteractionObject>();
        NPC2 = GameObject.Find("NPC2").GetComponent<InteractionObject>();
        NPC3 = GameObject.Find("NPC3").GetComponent<InteractionObject>();
        NPC4 = GameObject.Find("NPC4").GetComponent<InteractionObject>();
        NPC5 = GameObject.Find("NPC5").GetComponent<InteractionObject>();
        Coin = GameObject.Find("Coin").GetComponent<InteractionObject>();
        Shovel = GameObject.Find("Shovel").GetComponent<InteractionObject>();
        Carrot = GameObject.Find("Carrot").GetComponent<InteractionObject>();
        Scroll = GameObject.Find("Scroll").GetComponent<InteractionObject>();
        GemSign = GameObject.Find("Gem Sign").GetComponent<InteractionObject>();
        Gem = GameObject.Find("Gem").GetComponent<InteractionObject>();
        sceneSwitcher = GameObject.Find("Scene Switcher").GetComponent<SceneSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {
        if (NPC5.initalConvoFinished == false)
        {
            Coin.gameObject.SetActive(false);
        }
        else
        {
            Coin.gameObject.SetActive(true);
        }

        if (NPC1.thirdConvoFinished == false)
        {
            Shovel.gameObject.SetActive(false);
        }
        else
        {
            Shovel.gameObject.SetActive(true);
        }

        if (NPC4.thirdConvoFinished == false)
        {
            Scroll.gameObject.SetActive(false);
        }
        else
        {
            Scroll.gameObject.SetActive(true);
        }

        if (NPC2.thirdConvoFinished == false)
        {
            Carrot.gameObject.SetActive(false);
        }
        else
        {
            Carrot.gameObject.SetActive(true);
        }


        if (Scroll.obtained == false)
        {
            GemSign.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GemSign.GetComponent<BoxCollider2D>().enabled = true;
        }

        if (GemSign.signRead == true && NPC3.thirdConvoFinished == true)
        {
            NPC3.gameObject.SetActive(false);
        }

        if (Gem.obtained == true)
        {
            sceneSwitcher.WinGame();
        }
    }
}
