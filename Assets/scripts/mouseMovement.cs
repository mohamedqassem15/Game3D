using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMovement : MonoBehaviour
{
    //script for moving camera with mouse
    [SerializeField] Transform player;
    public float mouseSensitivity = 100f;
 
 //controlling the rotation of the y and x axias
    float xRotation = 0f; //looking up and down
    float YRotation = 0f; //looking left and right
 
    void Start()
    {
      //Locking the cursor to the middle of the screen and making it invisible
      Cursor.lockState = CursorLockMode.Locked;
    }
 
    void Update()
    {
       float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
 
       //control rotation around x axis (Look up and down)
       xRotation -= mouseY;
     
       //we clamp the rotation so we cant Over-rotate (like in real life)
       xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
       //control rotation around y axis (Look up and down)
       YRotation += mouseX;
 
       //applying both rotations
       transform.localRotation = Quaternion.Euler(xRotation, 0, 0f);
        player.localRotation = Quaternion.Euler(0f, YRotation, 0f);
    }
}
