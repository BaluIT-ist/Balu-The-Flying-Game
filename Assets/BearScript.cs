using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrenght;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            myRigidBody.velocity = Vector2.up * flapStrenght; 
        }
        
    }
}
