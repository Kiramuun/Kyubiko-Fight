using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapePause : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            Time.timeScale = 0f;
            SceneManager.LoadScene("UI MenuPause", LoadSceneMode.Additive); 
        }
    }
}
