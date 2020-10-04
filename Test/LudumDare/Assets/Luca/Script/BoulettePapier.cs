using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulettePapier : MonoBehaviour
{
    public GameObject hint;
    void Start()
    {
        
    }

    void Update()
    {
        var boule = GameObject.Find("Boulette").GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();

        if(boule.isPlayer){
            if(Input.GetKeyDown("e")){
                player.GetPapier();
                hint.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
