using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float movementX;
    private float movementZ;
    public float speed;
    
    void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        movementZ = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        transform.position += new Vector3(movementX, 0, movementZ);
        /*
        transform.position += Vector3.forward * movementZ;
        transform.position += Vector3.right * movementX;
        */
        
    }
}
