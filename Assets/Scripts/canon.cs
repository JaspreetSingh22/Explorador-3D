using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public GameObject Fireball;
    public Transform Firepoint;
    public float TimeInterval = 2f;

    private float timeSinceLastFire = 0f;
    

    // Update is called once per frame
    void Update()
    {
        timeSinceLastFire += Time.deltaTime;
        if (timeSinceLastFire >= TimeInterval)
        {
            Fire();
            timeSinceLastFire = 0f;
        }
    }
    void Fire()
    {
        if (transform.localScale.x < 0) // If facing left
        {
            Instantiate(Fireball, Firepoint.position, Quaternion.Euler(0, 0, 180f));
        }
        else
        {
            Instantiate(Fireball, Firepoint.position, Firepoint.rotation);
        }
     
    }
}
