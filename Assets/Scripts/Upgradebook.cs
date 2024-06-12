using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgradebook : MonoBehaviour
{
    public GameObject Notificationbox;
    public GameObject BookEffect;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        Instantiate(BookEffect, transform.position, Quaternion.identity);
        GameStateManager.Instance.OnUpgradeShoot();
        Notificationbox.SetActive(true);
        Destroy(gameObject);
    }
}
