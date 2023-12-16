using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public CharacterController controller;
    public GameObject footstep;
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Horizontal") != 0) && controller.isGrounded)
        {
            footsteps();
        }
        else if ((Input.GetAxis("Vertical") != 0) && controller.isGrounded)
        {
            footsteps();
        }
        else
        {
            stopFootsteps();
        }
    }

    void footsteps()
    {
        footstep.SetActive(true);
    }
    void stopFootsteps()
    {
        footstep.SetActive(false);
    }
}
