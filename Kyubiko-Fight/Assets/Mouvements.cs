using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    Vector2 _movementInput;
    Animator _animatorRef;
    Rigidbody2D _rigidB;
    public float _speed;
    bool _right;

    void Awake()
    {
        _animatorRef = GetComponentInChildren<Animator>();
        _rigidB = GetComponent<Rigidbody2D>();
        _right = true;
    }

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"),
              vertical = Input.GetAxisRaw("Vertical");

        _movementInput = new Vector2(horizontal, vertical).normalized;

        Vector2 dir = new Vector2(horizontal, 0);
        dir = dir.normalized;
        float localCurrentX = transform.localScale.x;
        if (dir.x < 0)
        {
            //if (dir.x == localCurrentX) { }
            transform.localScale = new Vector3(-0.5f,0.5f,0.5f);
        }
        if (dir.x > 0)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        /*if (localCurrentX < 0)
        {
            _right = false;
        }
        if (localCurrentX > 0)
        {
            _right=true;
        }*/

        //Permet de passer en "Mode Sprint" en augmentant la vitesse quand on appuie
        //et la rebaissant quand la touche est relacher.
        if (Input.GetKeyDown(KeyCode.LeftShift)) { _speed *= 2f; }
        if (Input.GetKeyUp(KeyCode.LeftShift)) { _speed /= 2f; }

        _animatorRef.SetFloat("Horizontal", horizontal);
    }

    void FixedUpdate()
    {
        Vector2 velocity = _movementInput * _speed;
        _rigidB.velocity = velocity;

        _animatorRef.SetFloat("speedMove", Mathf.Abs(_rigidB.velocity.magnitude));
    }
}
