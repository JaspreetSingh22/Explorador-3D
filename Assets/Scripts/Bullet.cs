using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        Destroy(gameObject, 3f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy") || collision.collider.CompareTag("ObjectOnButton")|| collision.collider.CompareTag("BreakableDoor"))
        {
            if(collision.collider.CompareTag("Enemy") && GameStateManager.Instance.GetCanKill())
            {
                Destroy(collision.collider.gameObject);
            }
            Destroy(gameObject);
        }
        
    }
   


}
