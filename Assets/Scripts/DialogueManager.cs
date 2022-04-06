using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueUI;
    public TMP_Text textBox;
    private GameObject player;
    private Animator playerAnimator;
    private Queue<string> dialogueQueue;

    // Start is called before the first frame update
    void Start()
    {
        dialogueQueue = new Queue<string>();
        player = GameObject.Find("Player");
        playerAnimator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartConversation(string[] sentences)
    {
        dialogueQueue.Clear();
        dialogueUI.SetActive(true);
        player.GetComponent<PlayerMovement_2D>().enabled = false;
        player.GetComponent<PlayerInteraction>().enabled = false;

        playerAnimator.SetFloat("Speed", 0);
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        foreach (string currentline in sentences)
        {
            dialogueQueue.Enqueue(currentline);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (dialogueQueue.Count == 0)
        {
            EndConversation();
            return;
        }

        string currentline = dialogueQueue.Dequeue();

        textBox.text = currentline;
    }

    public void EndConversation()
    {
        dialogueUI.SetActive(false);
        player.GetComponent<PlayerMovement_2D>().enabled = true;
        player.GetComponent<PlayerInteraction>().enabled = true;
    }
}
