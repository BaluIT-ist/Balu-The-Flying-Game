using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrenght;
    public LogicScript logic;
    public bool bearIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)== bearIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrenght;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
    }
}
 