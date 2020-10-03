using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsHere : MonoBehaviour
{
    public bool isPlayer;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag == "Player"){ 
            isPlayer = true;

        }
    }

     void OnTriggerExit2D(Collider2D col){
         if (col.gameObject.tag == "Player"){ 
            isPlayer = false;

        }
     }
}
