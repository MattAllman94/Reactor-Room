using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class DoorController : MonoBehaviour
{
    public TextMeshProUGUI openText;

    public GameObject doorLeft;
    public GameObject doorRight;
    public Ease ease;

    public Vector3 doorLeftOpenPOS = new Vector3(2f, 0, 0);
    public Vector3 doorRightOpenPOS = new Vector3(-2f, 0, 0);

    public Vector3 doorLeftClosePOS = new Vector3(0, 0, 0);
    public Vector3 doorRightClosePOS = new Vector3(0, 0, 0);

    private void Start()
    {
        openText.text = "";
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

            openText.text = "Press 'E' to open door";
            if(Input.GetKeyDown(KeyCode.E))
            {
                openText.text = "";
                doorLeft.transform.DOMove(doorLeftOpenPOS, 1).SetEase(ease);
                doorRight.transform.DOMove(doorRightOpenPOS, 1).SetEase(ease);
            }
    }

    private void OnTriggerExit(Collider other)
    {
          openText.text = "";
          doorLeft.transform.DOMove(doorLeftClosePOS, 3).SetEase(ease);
          doorRight.transform.DOMove(doorRightClosePOS, 3).SetEase(ease);
    }
}
