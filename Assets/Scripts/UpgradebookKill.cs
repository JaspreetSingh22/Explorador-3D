using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradebookKill : MonoBehaviour
{
    public GameObject Notificationbox;
    public GameObject BookEffect;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        Instantiate(BookEffect, transform.position, Quaternion.identity);
        GameStateManager.Instance.OnUpgradeShootKill();
        Notificationbox.SetActive(true);
        Destroy(gameObject);
    }
}
