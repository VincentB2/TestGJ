using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLock : MonoBehaviour
{
    public bool isLock;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag == "Lock"){ 
            isLock = true;

        }
    }

    void OnTriggerExit2D(Collider2D col){
         if (col.gameObject.tag == "Lock"){ 
            isLock = false;

        }
     }
}
