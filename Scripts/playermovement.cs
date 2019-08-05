using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float speed;
    public float accel;

    private float currentSpeed;
    private float targetSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetSpeed = Input.GetAxisRaw("Horizontal") * speed;
        //currentSpeed
    }
    /**
    private float IT(float m, float target, float a)
    {
        if (name == target)
        {
           // return n; 
        }
        else
        {
            //float dir =Mout
        }
    }
    */
}
