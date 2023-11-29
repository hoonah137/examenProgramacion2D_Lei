using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded = false;

    //call

    void OnTriggerEnter(Collider2D Layer == 9)
    {
        isGrounded = true;
    }

   void OnTriggerStay(Collider2D Layer == 9)
    {
        isGrounded = true;
    }

   void OnTriggerExit(Collider2D Layer == 9)
    {
        isGrounded = false;
    }
}
