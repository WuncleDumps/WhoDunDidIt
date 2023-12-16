using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                // Check if the object has a DialogueTrigger component
                if (collider.TryGetComponent(out DialogueTrigger dialogueTrigger))
                {
                    dialogueTrigger.TriggerDialogue();
                }
            }
        }
    }

}
