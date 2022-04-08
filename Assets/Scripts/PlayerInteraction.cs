using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInteractObj;
    public InteractionObject currentObjScript;
    public bool firstStep;
    public bool secondStep;
    public bool thirdStep;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractObj != null)
        {
            CheckInteraction();
        }
    }

    void CheckInteraction()
    {
        Debug.Log("Current object type: " + currentInteractObj.name);

        if (currentObjScript.objType == InteractionObject.ObjectType.nothing)
        {
            currentObjScript.Nothing();
        }
        else if (currentObjScript.objType == InteractionObject.ObjectType.readable)
        {
            currentObjScript.Readable();
        }
        else if (currentObjScript.objType == InteractionObject.ObjectType.pickup)
        {
            currentObjScript.Pickup();
        }
        else if (currentObjScript.objType == InteractionObject.ObjectType.npc)
        {
            currentObjScript.NPC();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Interactible") == true)
        {
            currentInteractObj = other.gameObject;
            currentObjScript = other.gameObject.GetComponent<InteractionObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        currentInteractObj = null;
        currentObjScript = null;
    }
}
