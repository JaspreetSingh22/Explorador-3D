using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float Speed = 5f;
    public float TimeToDestroy = 2f;
    
    
    void Update()
    {
       
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            Destroy(gameObject, TimeToDestroy);
       
        
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("ObjectOnButton") || other.CompareTag("BreakableDoor"))
        {
            
            Destroy(gameObject);
        }
    }


}
