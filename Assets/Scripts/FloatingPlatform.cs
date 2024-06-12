using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatform : MonoBehaviour
{
    public Transform waypointA;
    public Transform waypointB;
    public float speed = 2f;

    private void Update()
    {
        float t = Mathf.PingPong(Time.time * speed, 1f); 
        transform.position = Vector3.Lerp(waypointA.position, waypointB.position, t);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SetParent(transform);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.transform.SetParent(null);
    }
}

