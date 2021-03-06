using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{

    //The chest object must have a collider set to “isTrigger” in the inspector


    //reference to the player script to check the player lockPickSkill.
    //PlayerControllerThatLevelsUp must have a int variable called ”currentLockPickSkill”

    private PlayerControllerThatLevelsUp playerControllerThatLevelsUp;


    private int DiceRollResult = 0;
    public int ChestDifficulty = 0;

    //the coin that will be spawned when the chest is opened, setting a prefab for instantiation later
    //public Transform Cog;


    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.GetComponent<PlayerControllerThatLevelsUp>())
        {
            playerControllerThatLevelsUp = other.gameObject.GetComponent<PlayerControllerThatLevelsUp>();
            //PlayerControllerThatLevelsUp must have a int variable called ”currentLockPickSkill”
            CheckIfLockPickIsSuccessful();

        }

    }


    //PlayerControllerThatLevelsUp must have a int variable called ”currentLockPickSkill”
    private void CheckIfLockPickIsSuccessful()
    {
        DiceRollResult = Random.Range(0, 6);

        if (DiceRollResult + playerControllerThatLevelsUp.currentLockPickSkill >= ChestDifficulty)
        {
            //Instantiate(Cog, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (playerControllerThatLevelsUp.currentLockPickSkill + 5 < ChestDifficulty)
        {
            print("you are not a high enough level");
        }
    }// if you dont have a high enough level, it will print on screen "you are not a high enough level" and you won't get the coin inside

}