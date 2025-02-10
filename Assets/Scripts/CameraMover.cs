using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float cameraSpeed = 20f;

    void LateUpdate()
    {
        // Move the CameraTarget right at a constant speed
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
