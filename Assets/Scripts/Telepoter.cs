using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telepoter : MonoBehaviour
{
    public Transform TeleportPos;
    public GameObject Transition;
    public GameObject Player;
    public PlayerController PlayerController;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(TransitionC());

            GameObject CollisionObject = collision.gameObject;

            Transition.SetActive(true);
        }
        
        
    }
    IEnumerator TransitionC()
    {
        yield return new WaitForSeconds(1);
        Player.transform.position = TeleportPos.position;
        yield return new WaitForSeconds(1);
        Transition.SetActive(false);
        PlayerController.UpdateCheckpoint();
    }
}
