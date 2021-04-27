using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlidingDoor : MonoBehaviour
{
    Animator anim;
    public bool playerPresent = false;



    void Start()
    {
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        if (playerPresent)
        {
            anim.SetBool("Open", true);
            anim.SetBool("Close", false);
        }

        else if(!playerPresent)
        {
            anim.SetBool("Close", true);
            anim.SetBool("Open", false);
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerPresent = true;
        }
        else
        {
            playerPresent = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerPresent = false;
        }
        else
        {
            playerPresent = true;
        }
    }
}
