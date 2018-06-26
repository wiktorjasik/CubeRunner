using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public GameObject platform;
    public Transform generationPoint2;
    public Transform player;
    int distancePlatforms = 100;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < (transform.position.y - 0.5))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (transform.position.z < generationPoint2.position.z)
        {            
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z + distancePlatforms);
            Instantiate(platform, transform.position, transform.rotation);            
        }
    }
}
