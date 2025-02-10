using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float speed, length;
    public float startX;
    public GameObject cam;
    

    void Start(){
        startX = transform.position.x;
        float cameraHeight = Camera.main.orthographicSize * 2;
        length = cameraHeight * Camera.main.aspect;
    }
    void Update()
    {
        float distance = cam.transform.position.x*speed;
        float movement = cam.transform.position.x*(1-speed);

        transform.position = new Vector3(startX + distance, transform.position.y, transform.position.z);

        if(movement > startX + length){
            startX += length;
		}
    }
}
