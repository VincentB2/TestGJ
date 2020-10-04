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

    public bool isPaused;

    public GameObject PapierUI;
    public bool HavePapier;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speedHBase, speedVBase);

        if(isPaused == false){

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

        if(isPaused){
            Time.timeScale = 0;
        }else{
            Time.timeScale = 1;
        }
        if(Input.GetKeyDown("1")){
            if(HavePapier){
                if(PapierUI.activeInHierarchy){
                    PapierUI.SetActive(false);
                }else{
                    PapierUI.SetActive(true);
                }
            }
        }


    }

    public void GetPapier(){
        HavePapier = true;
    }
}
