using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public void Play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
        FindObjectOfType<AudioManager>().Play("Click");
        StartCoroutine("play2");
    }

    IEnumerator play2(){
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Luca", LoadSceneMode.Single);
    }

    public void Options()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        StartCoroutine("opt2");
    }

    IEnumerator opt2(){
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }

    public void Credits()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        StartCoroutine("cred2");
    }

    IEnumerator cred2(){
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void returnToMenu(){     
        FindObjectOfType<AudioManager>().Play("Click");
        StartCoroutine("rtm2");
    }

    IEnumerator rtm2(){
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Menu 1", LoadSceneMode.Single);
    }

    public void Exit()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        StartCoroutine("exit2");

    }

    IEnumerator exit2(){
        yield return new WaitForSeconds(0.2f);
        Application.Quit();
    }

}
