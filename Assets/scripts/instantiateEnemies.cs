using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateEnemies : MonoBehaviour
{

    //private GameObject grid;

    public int enemyRows = 5;
    public int enemyColumns = 11;
    public float enemyDistance = 1f;
    public float enemyRowDistance = 1f;
    public Vector2 startingPoint;
    public float scale = 1f;
    private GameObject[,] enemyGrid;


    // Use this for initialization
    void Start () {
            
        enemyGrid = new GameObject[enemyRows, enemyColumns];

        //GameObject enemySwarm = new GameObject();
        //enemySwarm.name = "EnemySwarm";

        for (int i = 0; i < enemyRows; i++)
        {
            for (int j = 0; j < enemyColumns; j++)
            {
                GameObject enemyInstance = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
                enemyInstance.transform.localScale = new Vector3(scale, scale);
                enemyInstance.transform.Translate(startingPoint + new Vector2(enemyDistance*j, enemyRowDistance*i));
                enemyInstance.transform.parent = transform;
                enemyGrid[i, j] = enemyInstance;
            }
        }
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
