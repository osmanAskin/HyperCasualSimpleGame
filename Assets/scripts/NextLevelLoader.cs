using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoader : MonoBehaviour
{
    public void AgainButton()
    {
        SceneManager.LoadScene("Scene1");
        Debug.Log("Seviye 1");
    }

    public void NextButton() 
    {
        SceneManager.LoadScene("Scene2");
        Debug.Log("Yeni Seviye");
    }

}
