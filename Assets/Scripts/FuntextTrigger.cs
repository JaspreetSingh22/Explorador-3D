using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuntextTrigger : MonoBehaviour
{
    public GameObject FunText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FunText.SetActive(true);
            Destroy(gameObject);
        }
        
    }
   
}
