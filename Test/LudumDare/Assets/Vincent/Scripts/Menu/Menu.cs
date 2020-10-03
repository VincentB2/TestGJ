using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }

    public void Exit()
    {

        Application.Quit();

    }

}
