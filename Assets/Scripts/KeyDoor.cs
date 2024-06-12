using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public int KeyCollected = 0;
    public int KeyNeed = 3;
    
    void Update()
    {

        // Check if all three keys are collected
        if (KeyCollected == KeyNeed)
        {
            OpenDoor();
        }
    }
    //To open door
    private void OpenDoor()
    {
        Destroy(gameObject ,1f);
    }
    //To increase no of keys collected
    public void keyCollect()
    {
        KeyCollected += 1;
      
    }
}
