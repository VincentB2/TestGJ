using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    bool endScene;
    public Animator flash;
    public BoolVariable canReset;

    void Start()
    {
        canReset.Value = true;
    }

    void Update()
    {
         var PIH = GameObject.Find("Portal").GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();

        if(PIH.isPlayer){
            if(Input.GetKeyDown("e") && canReset.Value){
                StartCoroutine("EndScene");
                
            }
        }
    }

    IEnumerator EndScene()
    {
        canReset.Value = false;
        flash.SetTrigger("Slow");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End", LoadSceneMode.Single);
    }

}
