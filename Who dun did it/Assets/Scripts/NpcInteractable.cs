using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour
{
    public void Interact(){
        ChatBubble.Create(transform.transform, new Vector3(-.3f,1.7f,0f), "Hello There");    }
}