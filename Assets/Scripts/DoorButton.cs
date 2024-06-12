using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public bool OpenDoor = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ObjectOnButton") || collision.CompareTag("Player"))
        {
            OpenDoor = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        OpenDoor = false;
    }
}
