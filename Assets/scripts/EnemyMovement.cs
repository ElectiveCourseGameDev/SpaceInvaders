using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float Speed; // moving speed
    public float VerticalMove; // how far they move vertically
    public float HorizontalMove; // how far they move horizontally

    private Vector2 destination; // destination they move towards

    private enum Move { LEFT, POSTLEFT, RIGHT, POSTRIGHT};
    private int statesLength = Enum.GetNames(typeof(Move)).Length;

    private Move currentMove = Move.RIGHT; // current direction
	// Use this for initialization
	void Start ()
	{

	    destination = SetDestination();
        Debug.Log(currentMove);
        Debug.Log(destination);
        
	}
	
	// Update is called once per frame
	void Update () {
        
        // has reached destination
        if (Vector3.Distance(transform.position, destination) < 0.01f)
        {
            currentMove = (Move) NextMove();
            destination = SetDestination();
            Debug.Log(currentMove);
            Debug.Log(destination);
        }
       
        // move towards destination point
        float step = Speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, destination, step);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextMove();
        }
    }

    private int NextMove()
    {
        //Debug.Log(currentMove);
        int move = (int) currentMove;
        move++;
        if (move >= statesLength)
        {
            return 0;
        }
        return move;
    }

    //Debug.Log(currentMove);
    public Vector2 SetDestination()
    {
        switch (currentMove)
        {
            case Move.LEFT:
                return transform.position + Vector3.left * HorizontalMove;
                break;
            case Move.POSTLEFT:
                return transform.position + Vector3.down * VerticalMove;

                break;
            case Move.RIGHT:
                return transform.position + Vector3.right * HorizontalMove;
                break;
            case Move.POSTRIGHT:
                return transform.position + Vector3.down * VerticalMove;
                break;
            default:
                return destination;
        }
    }
        
    }


