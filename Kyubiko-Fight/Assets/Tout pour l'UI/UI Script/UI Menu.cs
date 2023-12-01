using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[CreateAssetMenu]
public class UIMenu : ScriptableObject
{
    public Slider _musicSlide;
    public AudioMixerGroup _group;
    
    void Start()
    {
        
    }
    public void SliderChange()
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

    public void FermetureFenetre()
    {
        SceneManager.UnloadSceneAsync(3);
    }

    public void Options()
    {
        SceneManager.LoadScene("UI MenuOption", LoadSceneMode.Additive);
    }

    public void Exit()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
