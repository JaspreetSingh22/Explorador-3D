using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoor : MonoBehaviour
{
    public float MaxUP;
    public float MaxDOWN;
    public DoorButton Button;
    public float DoorSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Button.OpenDoor && transform.position.y <= MaxUP)
        {
            transform.Translate(Vector3.up * DoorSpeed * Time.deltaTime);
       }
        else if (Button.OpenDoor == false && transform.position.y >= MaxDOWN)
        {
            transform.Translate(Vector3.down * DoorSpeed * Time.deltaTime);
        }
    
    }
}
