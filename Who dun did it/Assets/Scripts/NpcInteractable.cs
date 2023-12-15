using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour
{
    public GameObject dialogBox; 
    public void Interact()
    {
        Instantiate(dialogBox,new Vector3(0f,0f,0f),transform.rotation); 
        //ChatBubble.Create(transform.transform, new Vector3(-.3f,1.7f,0f), "Hello There");   
    }
}