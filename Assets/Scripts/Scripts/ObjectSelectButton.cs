using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelectButton : MonoBehaviour
{
    public List<Sprite> buttonSpriteList;
    Vector2 position2D;
    public GameObject jumpPad;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().position = position2D;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touchButton = Input.GetTouch(0);

            if (position2D == touchButton.position)
            {
                 GetComponent<SpriteRenderer>().sprite = buttonSpriteList[1];
            }
        } 

        if (GetComponent<SpriteRenderer>().sprite = buttonSpriteList[1])
        {
            if (Input.touchCount > 0)
            {
                Touch touchSpawn = Input.GetTouch(1);
                //Quaternion spawnRotation = new Vector3(0, 0, 0);
                //Instantiate(jumpPad, touchSpawn.position, );
            }
        }
    } 

    void SpawnJumpPad()
    {
        
    }
}
