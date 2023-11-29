using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class UIMenu : ScriptableObject
{
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void RetourMainMenu()
    {
        SceneManager.LoadScene("UI Menu", LoadSceneMode.Single);
    }

    public void Options()
    {

    }

    public void Exit()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
