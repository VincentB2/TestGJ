using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
         var PIH = GameObject.Find("Portal").GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();

        if(PIH.isPlayer){
            if(Input.GetKeyDown("e")){
                SceneManager.LoadScene("Luca", LoadSceneMode.Single);
            }
        }
    }
}
