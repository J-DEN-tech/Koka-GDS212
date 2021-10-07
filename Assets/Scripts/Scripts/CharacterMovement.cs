using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 0.1f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement of the player happens at the start of the game
        this.transform.position += this.transform.right * moveSpeed * Time.deltaTime;
        // Rotate player via A/D keys
        // Identify this position, set the vertical axis as the axis to rotate around the set the rotation speed.
        // Then limit the rotation so the character can turn but still keep moving ahead.

        {

            


        }
        
        {

           


        }

       
        }



    }
  



