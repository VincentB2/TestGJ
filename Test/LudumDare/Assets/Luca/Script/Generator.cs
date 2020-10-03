using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int genCode0;    
    public int genCode1;    
    public int genCode2;    
    public int genCode3;
    public GameObject digitUI;

    void Start()
    {
        /*var randomPaper = GameObject.Find("RandomCode0").GetComponent<RandomPaper>();
        genCode0 = randomPaper.GeneratorCode0;
        genCode1 = randomPaper.GeneratorCode1;
        genCode2 = randomPaper.GeneratorCode2;
        genCode3 = randomPaper.GeneratorCode3;*/

        Debug.Log(genCode0);
        Debug.Log(genCode1);
        Debug.Log(genCode2);
        Debug.Log(genCode3);

    }

    void Update()
    {
        var PIH = GameObject.Find("Generator").GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();

        if(PIH.isPlayer){
            if(Input.GetKeyDown("e")){
                player.isPaused = true;
                digitUI.SetActive(true);
            }
        }
    }

    public void closeDigit(){
        var PIH = GameObject.Find("Generator").GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();
        
        player.isPaused = false;
        digitUI.SetActive(false);
    }
}
