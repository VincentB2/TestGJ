using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speedH;
    public float speedV;
    private float speedHBase;
    private float speedVBase;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speedHBase, speedVBase);

        if(Input.GetKey("z")){
            speedVBase = speedV;
        }else if(Input.GetKey("s")){
            speedVBase = -speedV;
        }else{
            speedVBase = 0;
        }

        if(Input.GetKey("q")){
            speedHBase = -speedH;
        }else if(Input.GetKey("d")){
            speedHBase = speedH;
        }else{
            speedHBase = 0;
        }


    }
}
