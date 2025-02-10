using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class cloudGeneration : MonoBehaviour
{
    public Tile cloud;
    public Tilemap tilemap;
    public float xPos;
	int cloudx;//number between 5 and 10 where cloud will spawn
	int cloudy;//number between 1 and 2 where cloud will spawn
    public float cloudSpawnInterval = 3f;
    private float nextCloudSpawnTime = 0f;
    public SpriteRenderer Duck;

    void Start(){
        xPos = Camera.main.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        xPos = Camera.main.transform.position.x;

        if (Time.time >= nextCloudSpawnTime)
        {

            
            cloudx = Random.Range(10, 20);
            cloudy = Random.Range(-3, 1);

            tilemap.SetTile(new Vector3Int(Mathf.FloorToInt(cloudx + xPos), cloudy, 0), cloud);

            nextCloudSpawnTime = Time.time + cloudSpawnInterval;
        }
    }
}
