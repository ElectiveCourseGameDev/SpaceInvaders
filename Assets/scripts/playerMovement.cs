using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float movementSpeed = 0.2f;
    public float leftBoundaries = -2.75f;
    public float rightBoundaries = 2.75f;

    public float swipeMinimum = 5;
    public enum gesture { swipeLeft, swipeRight, tap };

    private int swipeFingerId;
    private gesture currentSwipe;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        // for touch input
        for (int i = 0; i < Input.touchCount; i++)
        {
            gesture currentTouch = detectTouch(Input.GetTouch(i));
            Debug.Log(currentTouch + "(" + Input.GetTouch(i).deltaPosition.sqrMagnitude + ")");
            Debug.Log(Input.GetTouch(i).deltaPosition.sqrMagnitude);
            switch (currentTouch)
            {
                case gesture.swipeLeft:
                    transform.Translate(Vector2.left * movementSpeed);
                    break;
                case gesture.swipeRight:
                    transform.Translate(Vector2.right * movementSpeed);
                    break;
                case gesture.tap:
                    SendMessage("shoot");
                    break;
                default:
                    break;
            }
        }


        // keyboard input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendMessage("shoot");
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > leftBoundaries)
        {
            transform.Translate(Vector2.left * movementSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= rightBoundaries)
        {
            transform.Translate(Vector2.right * movementSpeed);
        }


    }

    private gesture detectTouch(Touch t)
    {
        if (t.deltaPosition.sqrMagnitude > swipeMinimum)
            if (t.deltaPosition.x < 0)
                return gesture.swipeLeft;
        if (t.deltaPosition.x > 0)
            return gesture.swipeRight;

        else return gesture.tap;
    }

}
