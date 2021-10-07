using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorScript : MonoBehaviour
{
    /*This Script Adds a force to an object that has collided with the object this 
     * script is attached to. 
     * Must have 
     * - One Box Collider*/ 

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");
        other.GetComponent<Rigidbody>().AddForce(Vector3.right, ForceMode.Impulse);
    }
}
