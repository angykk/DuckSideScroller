using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;


public class LoadGame : MonoBehaviour
{
    public Tilemap tilemap;
    public SpriteRenderer Duck;
    // Start is called before the first frame update
    void Start()
    {
    }

void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject==tilemap.gameObject)
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
 
}
