using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
 
    public float speed = 12f;
    private float normalSpeed;
    public float doubleSpeed = 2;
    private float timer;
    
    public float gravity = -9.81f * 2;
    public float jumpHeight = 3f;
 
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    [SerializeField] Animator charateranimation;
    Vector3 velocity;
 
    bool isGrounded;

    private void Start()
    {
        normalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //checking if we hit the ground to reset our falling velocity, otherwise we will fall faster the next time
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
 
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
 
        //right is the red Axis, foward is the blue axis
        Vector3 move = transform.right * x + transform.forward * z;
 
        controller.Move(move * speed * Time.deltaTime);
        if (x > 0.1 || z > 0.1 || x< -.1 || z<-0.1)
        {
            charateranimation.SetBool("ismoving", true);
        }
        else {
            charateranimation.SetBool("ismoving", false);
        }
        //check if the player is on the ground so he can jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //the equation for jumping
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
 
        velocity.y += gravity * Time.deltaTime;
 
        controller.Move(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "speedPowerup")
        {
            speed *= doubleSpeed;
            StartCoroutine(T());

        }
    }

    IEnumerator T()
    {
        yield return new WaitForSeconds(timer);
        speed = normalSpeed;
    }
}
