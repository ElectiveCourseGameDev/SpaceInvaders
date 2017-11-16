using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipMovement : MonoBehaviour {

    public float speed;
    public Vector2 boundaryLeft;
    public Vector2 boundaryRight;
    
    private Vector2 destination;

    private enum move { LEFT, RIGHT };

    // Use this for initialization
    void Start () {
        destination = boundaryRight;
	}
	
	// Update is called once per frame
	void Update () {
        // move towards destination point
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, destination, step);

        if (Vector3.Distance(transform.position, destination) < 0.01f)
        {
            destination = boundaryRight;
        }

        if (Vector3.Distance(transform.position, destination) < 0.01f)
        {
            destination = boundaryLeft;
        }

    }
}
