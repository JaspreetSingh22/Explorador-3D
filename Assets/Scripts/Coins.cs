using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [Tooltip("How much points you get for collecting this collectable")]
    public int CoinsValue;
    [Tooltip("Put Particle prefab in it")]
    public GameObject ParticlePrefab;
    /// <summary>
    /// This function will be called when the gameobject attached is part
    /// of a collection and one or both of the colliders are labeled 'triger'
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameStateManager.Instance.ChangeCoins(CoinsValue);
            if(ParticlePrefab != null)
            {
                //instaniate a new version of our prefab and save its reference to temp
                GameObject temp =GameObject.Instantiate(ParticlePrefab);
                temp.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }
}
