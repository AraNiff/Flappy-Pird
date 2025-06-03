using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStregth;
    public LogicScript logic;
    public bool birdIsAlive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birdIsAlive = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidBody.linearVelocityY = Vector2.up.y * flapStregth;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
