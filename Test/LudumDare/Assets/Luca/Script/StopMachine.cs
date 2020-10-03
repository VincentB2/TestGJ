using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMachine : MonoBehaviour
{

     public GameObject StopUI;

    void Start()
    {
        
    }

    void Update()
    {
        var PIH = GameObject.Find("StopMachine").GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();

        if(PIH.isPlayer){
            if(Input.GetKeyDown("e")){
                player.isPaused = true;
                StopUI.SetActive(true);
            }
        }

    }
}
