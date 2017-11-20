using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateEnemies : MonoBehaviour {

    public int enemyRows = 4;
    public int enemyRowLength = 16;
    public float enemyDistance = 1f;
    public float enemyRowDistance = 1f;
    public Vector2 startingPoint;
    public float scale = 1f;

	// Use this for initialization
	void Start () {

        GameObject enemySwarm = new GameObject();
        enemySwarm.name = "EnemySwarm";

        for (int i = 0; i < enemyRows; i++)
        {
            for (int j = 0; j < enemyRowLength; j++)
            {
                GameObject enemyInstance = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
                enemyInstance.transform.localScale = new Vector3(scale, scale);
                enemyInstance.transform.Translate(startingPoint + new Vector2(enemyDistance*j, enemyRowDistance*i));
                enemyInstance.transform.parent = enemySwarm.transform;
            }
        }
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
