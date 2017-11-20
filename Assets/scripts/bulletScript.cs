using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    public float speed;
    public Direction direction = Direction.UP;
    public GameObject owner;

    public enum Direction { UP, DOWN};
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float step = speed * Time.deltaTime;
        if (direction == Direction.UP) transform.Translate(Vector2.up * step);
        else transform.Translate(Vector2.down * step);
        
        if (transform.position.y > 5 ) // has left the scene
        {
            DestroyBullet();
        }
    }

    private void DestroyBullet()
    {
        owner.SendMessage("removeBullet");
        Debug.Log("SendMessage");
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (!coll.gameObject.Equals(owner))
        {
            //send killmesage to object
            coll.SendMessage("killGameObject");

            // destroy bullet
            DestroyBullet();
        }

    }

}
