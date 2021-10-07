using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog : MonoBehaviour
{
    public float spinSpeed = 100f;
    public int xpValue = 100;
    public AudioSource audioSource;
    public AudioClip audioClip;
    void Update()
    //void update means that once the game has started, it repeats for every frame
    {
        this.transform.Rotate(0f, 0f, Time.deltaTime * this.spinSpeed);
        //this line shows the spinning of the cog
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");

        if (other.gameObject.tag == "Player")
        {
            audioSource.Play();
            other.gameObject.GetComponent<PlayerControllerThatLevelsUp>().GainXP(xpValue);
            Destroy(this.gameObject);
        }


    }
}