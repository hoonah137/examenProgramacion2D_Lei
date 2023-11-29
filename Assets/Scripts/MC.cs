using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC : MonoBehaviour
{

    // Variables

    [SerializeField] float _vel = 5;

    float _playerHorizontal;
    float _playerVertical;
    

    // Components
    Rigidbody2D _rBody2D;

    // llama funcion
    void Start()
    {
        _rBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
        Jump();
    }

    void Update()
    {
        Anim();    
    }

    //funciones

    void Move()
    {
        _playerHorizontal = Input.GetAxis("Horizontal");
        _playerVertical = Input.GetAxis("Vertical");

        _rBody2D.velocity = new Vector2(_vel * _playerHorizontal, -4.9f);

    }

    void Jump()
    {

    }

    void Anim()
    {
       
    }
}
