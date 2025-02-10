using UnityEngine;
using System.Collections;
using UnityEngine.Tilemaps;


public class GroundMoveScript : MonoBehaviour {

	float speed = 5;//speed of the  ground moving
	public Tilemap tilemap;
    public Tile ground;//new tile to set - ground
	// Use this for initialization
	void Start () {
		for(int x = -15; x < 9; x ++){
			tilemap.SetTile(new Vector3Int(x, -3, 0), ground);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}
}