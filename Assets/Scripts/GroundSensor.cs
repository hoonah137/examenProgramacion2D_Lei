using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded = false;
    BoxCollider2D _collider;


    //call
    void Awake()
    {
        _collider = gameObject.GetComponent<BoxCollider2D>();
    }
    
    void OnTriggerEnter(Collider2D _collider)
    {        
        isGrounded = true;
    }

   void OnTriggerStay(Collider2D _collider)
    {
        isGrounded = true;
    }

   void OnTriggerExit(Collider2D _collider)
    {
      isGrounded = true;
    }
}
