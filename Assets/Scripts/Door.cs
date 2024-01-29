using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnim;
    [SerializeField] private GameObject door;
    
    void Start()
    {
        doorAnim = door.GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider) {
        if(collider.tag == "openDoor") {
            doorAnim.SetTrigger("Open");
        }
        if(collider.tag == "closeDoor") {
            doorAnim.SetTrigger("Close");
        }
    }
}
