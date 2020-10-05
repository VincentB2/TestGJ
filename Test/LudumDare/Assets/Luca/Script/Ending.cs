using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("end");
    }

    void Update()
    {
        
    }

    IEnumerator end(){
        yield return new WaitForSeconds(4.05f);
        SceneManager.LoadScene("Luca", LoadSceneMode.Single);
    }
}
