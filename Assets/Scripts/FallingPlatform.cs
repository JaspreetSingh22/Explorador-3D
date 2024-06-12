using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float fallDelay = 1.0f;
    private bool playerTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !playerTriggered)
        {
            Invoke("Fall", fallDelay);
            playerTriggered = true;
        }
    }

    private void Fall()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
        Destroy(gameObject, 1f);
    }
}
