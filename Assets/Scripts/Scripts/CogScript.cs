using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogScript : MonoBehaviour
{
    public float spinSpeed = 100f;
    public int xpValue = 100;

    void Update()
    //void update means that once the game has started, it repeats for every frame
    {
        this.transform.Rotate(0f, 0f, Time.deltaTime * this.spinSpeed);
        //this line shows the spinning of the cog
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigeered");

        if (other.gameObject.tag == "Player")
        {
           other.gameObject.GetComponent<PlayerControllerThatLevelsUpScript>().GainXP(xpValue);
            Destroy(this.gameObject);
        }


    }
}