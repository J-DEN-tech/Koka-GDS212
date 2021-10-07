using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InstantiateSpring : MonoBehaviour
{
    public GameObject objectToInstantiate;
    public Transform positionToInstantiate;
    public int numberOfObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntantiateObject()
    {
        Instantiate(objectToInstantiate, positionToInstantiate);
    }
}
