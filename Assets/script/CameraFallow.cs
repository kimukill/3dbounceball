using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    public Transform ball;
    private Transform tr;
 
    void Start()
    {
        tr = GetComponent<Transform>();
    }
 
    void LateUpdate()
    {
        tr.position = new Vector3(ball.position.x , ball.position.y + 6f, ball.position.z - 6f);
 
        tr.LookAt(ball);
    }
}
