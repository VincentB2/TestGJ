using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHint : MonoBehaviour
{
    public bool isInteraction;
    public GameObject text;
    void Start()
    {
        
    }

    void Update()
    {
        if(isInteraction){
            text.SetActive(true);
        }   else{
            text.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag == "Interaction"){ 
            isInteraction = true;

        }
    }

     void OnTriggerExit2D(Collider2D col){
         if (col.gameObject.tag == "Interaction"){ 
            isInteraction = false;

        }
     }
}
