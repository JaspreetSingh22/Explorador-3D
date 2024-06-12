using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxController : MonoBehaviour
{
    [Tooltip("The ratio that our background moves relative to the camera")]
    public float ParallaxFactorX = 1.0f;
    public float ParallaxFactorY = 1.0f;
    //parallax factor 0 - doesn't move, stick to the game world
    //Parallax factor 1-sticks to tje camera

    Vector3 cameraStartPostion; //initial postion of camera
    Vector3 startPostion; //for layer start postion

    // Start is called before the first frame update
    void Start()
    {
        //The inistial postion of the layer
        startPostion = transform.position;

        //Camera.main - static refrence to 
        //the first camera in our scene labeled "Main Camera"
        cameraStartPostion = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraDelta = Camera.main.transform.position - cameraStartPostion;


        //move our transform postion , to our start postion
        //plus the change om [ostion of the camera multiplied by our paralax factor
        //as a decimal percentage
        transform.position = startPostion + new Vector3(
            cameraDelta.x * ParallaxFactorX, cameraDelta.y * ParallaxFactorY);
    }
}
