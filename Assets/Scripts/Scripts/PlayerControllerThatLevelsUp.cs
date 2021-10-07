
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
       Player Controller that moves and turns faster as it gains XP;
	    Manages moving and rotating the player via the arrow keys.
		Up/down arrow keys to move forward and backward.
		Left/right arrow keys to rotate left and right.
*/

public class PlayerControllerThatLevelsUp : MonoBehaviour
{


    public int currentLockPickSkill;


    public float xp = 0;	// Amount of XP the player has
    public float xpForNextLevel = 10;   //Xp needed to level up, the higher the level, the harder it gets. 
    public int level = 0;   // Level of the player
    public float moveSpeed = 0.1f;



    // To level up you need to collect an amount of xp;
    // This starts at 10 xp
    // Each level you gain the xp required gets higher exponentially
    // The exponential growth is slowed by scaling it by 10%

    void SetXpForNextLevel()
    {
        xpForNextLevel = (10f + (level * level * 0.1f));
        Debug.Log("xpForNextLevel " + xpForNextLevel);
    }




    void LevelUp()
    {
        xp = 0f;
        level++;
        Debug.Log("level" + level);
        SetXpForNextLevel();
        



    }




    //a function to make the player gain the amount of Xp the you tell it. 
    public void GainXP(int xpToGain)
    {
        xp += xpToGain;
        Debug.Log("Gained " + xpToGain + " XP, Current Xp = " + xp + ", XP needed to reach next Level = " + xpForNextLevel);
    }


    void Update()
    {
        this.transform.position += this.transform.right * moveSpeed * Time.deltaTime;
        //Test the GainXp function by pressing the x button. 
        if (Input.GetKeyDown(KeyCode.X) == true) { GainXP(1); }


        //LevelUp when the appropriate conditions are met.
        if (xp >= xpForNextLevel)
        {
            LevelUp();
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigeered");

     //   if (other.gameObject.tag == "Player")
      //  {
     //       other.gameObject.GetComponent<PlayerControllerThatLevelsUp>().GainXP(xpValue);
      //      Destroy(this.gameObject);
      //  }


    }
}
