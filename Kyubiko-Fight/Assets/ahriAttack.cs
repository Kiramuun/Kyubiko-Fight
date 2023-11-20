using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaque : MonoBehaviour
{
    Animator _animatorRef;

    void Awake()
    {
        _animatorRef = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !_animatorRef.GetBool("attackSplash"))
        {
            _animatorRef.SetBool("attackSplash", true);
        }

        if (Input.GetButtonDown("Fire2") && !_animatorRef.GetBool("attackFireball"))
        {
            _animatorRef.SetBool("attackFireball", true);
        }

        if (Input.GetButtonDown("Fire3") && !_animatorRef.GetBool("Ultimate"))
        {
            _animatorRef.SetBool("Ultimate", true);
        }
    }
}
