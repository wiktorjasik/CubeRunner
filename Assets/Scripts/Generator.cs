using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject[] obstacles;
    public Transform generationPoint;
    int distanceObstacles = 50;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.z < generationPoint.position.z)
        {
            int obstacleIndex = Random.Range(0, obstacles.Length);
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z + distanceObstacles);
            Instantiate(obstacles[obstacleIndex], transform.position, transform.rotation);
        }        
    }
}
