using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    Vector2 _movementInput;
    public Animator _animatorRef;
    Rigidbody2D _rigidB;
    public float _speed;

    void Awake()
    {
        _rigidB = GetComponent<Rigidbody2D>();
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

        if (dir.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (dir.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        /*Vector3 dir = Vector3.zero;

        if (horizontal > 0)
        {
            _direction = 1;
            dir = Vector3.left;

            transform.localScale = new Vector3(_direction, transform.localScale.y, transform.localScale.z);
        }

        if (horizontal < 0)
        {
            _direction = -1;
            dir = Vector3.right;

            transform.localScale = new Vector3(_direction, transform.localScale.y, transform.localScale.z);
        }*/

        //Permet de passer en "Mode Sprint" en augmentant la vitesse quand on appuie
        //et la rebaissant quand la touche est relacher.
        if (Input.GetKeyDown(KeyCode.LeftShift)) { _speed *= 2f; }
        if (Input.GetKeyUp(KeyCode.LeftShift)) { _speed /= 2f; }

        _animatorRef.SetFloat("Horizontal", horizontal);
        //_animatorRef.SetFloat("Vertical", vertical);
    }

    void FixedUpdate()
    {
        Vector2 velocity = _movementInput * _speed;
        _rigidB.velocity = velocity;

        _animatorRef.SetFloat("speedMove", Mathf.Abs(_rigidB.velocity.magnitude));
    }
}
