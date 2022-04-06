using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionObject : MonoBehaviour
{
    public bool obtained;
    public enum ObjectType
    {
        nothing,
        readable,
        pickup,
        npc
    }

    [Header("Object Type")]
    public ObjectType objType;

    [Header("Readable Message")]
    public string message;
    private TMP_Text messageText;

    [Header("Npc Dialogue")]
    public string[] dialogue;
    private TMP_Text dialogueText;


    // Start is called before the first frame update
    void Start()
    {
        messageText = GameObject.Find("messageText").GetComponent<TMP_Text>();
        obtained = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Nothing()
    {
        Debug.LogWarning("This " + this.gameObject.name + " is set as type nothing");

    }

    public void Readable()
    {
        messageText.text = message;
        StartCoroutine(ShowMessage(message, 2.5f));
    }

    public void Pickup()
    {
        Debug.Log("Picked up " + this.gameObject.name);
        this.gameObject.GetComponent<Renderer>().enabled = false;
        obtained = true;
    }

    public void NPC()
    {
        GameObject.Find("DialogueManager").GetComponent<DialogueManager>().StartConversation(dialogue);
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        messageText.text = message;
        yield return new WaitForSeconds(delay);
        messageText.text = null;
    }
}
