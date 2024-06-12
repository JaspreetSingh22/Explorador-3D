using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoremover : MonoBehaviour
{
    public float Lifeseconds = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, Lifeseconds);
    }

   
}
