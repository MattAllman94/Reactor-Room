using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorController : MonoBehaviour
{
    public TextMeshProUGUI openText;
    public bool atDoor;

    public Animator anim;

    private void Start()
    {
        openText.text = "";
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        anim.SetBool("Close", false);
        if (other.gameObject.CompareTag("Player"))
        {
            openText.text = "Press 'E' to open door";
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Pressed E");
                openText.text = "";
                anim.SetBool("Open", true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openText.text = "";
            anim.SetBool("Close", true);
            anim.SetBool("Open", false);
        }
    }
}
