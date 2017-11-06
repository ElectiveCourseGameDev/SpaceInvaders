using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed;
    public float verticalMove;
    public float horizontalMove;

    private Vector2 destination;

    private enum move { LEFT, POSTLEFT, RIGHT, POSTRIGHT};
    private int statesLength = Enum.GetNames(typeof(move)).Length;

    private move currentMove = move.LEFT;
	// Use this for initialization
	void Start () {

        destination = transform.position + Vector3.right * 1;
        
	}
	
	// Update is called once per frame
	void Update () {

        // has reached destination
        if (Vector3.Distance(transform.position, destination) < 0.01f)
        {
            nextMove();
            switch (currentMove)
            {
                case move.LEFT:
                    destination = Vector2.left * horizontalMove;
                    break;
                case move.POSTLEFT:
                    destination = Vector2.down * verticalMove;
                    break;
                case move.RIGHT:
                    destination = Vector2.right * horizontalMove;
                    break;
                case move.POSTRIGHT:
                    destination = Vector2.down * verticalMove;
                    break;
            }
        }
        
        // move towards destination point
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, destination, step);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextMove();
        }
    }

    private void nextMove()
    {
        currentMove++;
        if ((int)currentMove >= statesLength)
        {
            currentMove = 0;
        }
       
        Debug.Log(currentMove);
    }
}
