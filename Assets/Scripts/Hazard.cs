using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public PlayerController playerreff;
    public GameObject HeartEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This will check to see if the object we are colliding with has a playercontroller
        //component,if so assign the reference to our variable playertemp
        //otherwise yje reference will be NULL!!!
        PlayerController playerTemp = collision.gameObject.GetComponent<PlayerController>();
        
        //Another way:
        //if(collision.gameobject.CompareTag("Player") //Check with the tag!
        if (playerTemp != null)
        {
            Instantiate(HeartEffect, transform.position, Quaternion.identity);
            playerreff = playerTemp;
            StartCoroutine(Death());
            //playerTemp.OnReset();
            playerreff.gameObject.SetActive(false);
            

        }
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(1.3f);
        GameStateManager.Instance.OnDeath();
        playerreff.OnReset();
        playerreff.gameObject.SetActive(true);
    }

}
