using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingDoor : MonoBehaviour
{
    public int HitPoint = 5;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            HitPoint -= 1;
        }
    }
    public void Update()
    {
        if(HitPoint < 1)
        {
            Destroy(gameObject);
        }
    }
}
