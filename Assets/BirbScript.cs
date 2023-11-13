using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float flapStrength;
    public LogicScript logic;
    public bool birdState = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdState)
        {
            myRigidBody2D.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y < -17 || transform.position.y > 16.5)
        {
            birdState = false;
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdState = false;
    }
}
