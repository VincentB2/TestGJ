using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusible : MonoBehaviour
{
    public int numberOfFusible;
    public GameObject me;
    void Start()
    {
        
    }

    void Update()
    {
        var fuse = me.GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();

        if(fuse.isPlayer){
            if(Input.GetKeyDown("e")){
                player.getFusible(numberOfFusible);
                FindObjectOfType<AudioManager>().Play("Fusible");
                Destroy(gameObject);
            }
        }
    }


}
