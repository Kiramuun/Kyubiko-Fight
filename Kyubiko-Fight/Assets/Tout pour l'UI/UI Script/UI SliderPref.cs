using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class UISliderPref : MonoBehaviour
{
    public string _fieldName = "Default",
                  _fieldNameMixer = "Default";
    Slider _slider;
    public AudioMixer _mixer;
    void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.value = PlayerPrefs.GetFloat( _fieldName );
    }

    public void SavePref(float value)
    {
        Debug.Log(value);
        PlayerPrefs.SetFloat(_fieldName, value);
        _mixer.SetFloat(_fieldNameMixer, value);
    }
}