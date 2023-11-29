using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC : MonoBehaviour
{

    // Variables

    [SerializeField] float _vel = 5;
    

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

    }

    void Jump()
    {

    }

    void Anim()
    {
       
    }
}
