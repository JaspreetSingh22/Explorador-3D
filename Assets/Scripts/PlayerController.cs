using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject FireballPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    private float nextFireTime = 0f;
    private Animator anim;
      


    //This is our initial start postion where our character will respawn
    private Vector3 startPostion;

    //REFF to our rigid body.
    private Rigidbody2D RB2D;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        startPostion = transform.position;
        
        RB2D = GetComponent<Rigidbody2D>();
        if (RB2D == null)
        {
            Debug.Log("Missing rigidbody");
        }
    }

    /// <summary>
    /// This function will handle when our player collides with a hazard
    /// </summary>
    public void OnReset()
    {
        Debug.Log("ressting player");
        //reset our player postion back ro our initial postion.
        transform.SetPositionAndRotation(startPostion, Quaternion.identity);

        //resets our velocity so that we don't get strange motion on reset
        RB2D.velocity = Vector3.zero;

    }
   
    public void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFireTime && GameStateManager.Instance.GetCanShoot())
        {
            Shoot();
            anim.SetTrigger("Shoot");
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    
    void Shoot()
    {
        // Determine the direction the player is facing
        Vector3 facingDirection = transform.localScale;
        if (facingDirection.x < 0) // If facing left
        {
            Instantiate(FireballPrefab, firePoint.position, Quaternion.Euler(0, 0, 180f));
        }
        else // If facing right
        {
            Instantiate(FireballPrefab, firePoint.position, Quaternion.identity);
        }

    }
    public void UpdateCheckpoint()
    {
        startPostion = transform.position;
    }
}
