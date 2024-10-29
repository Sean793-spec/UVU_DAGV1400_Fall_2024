using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    private Vector2 velocity;
    private Transform thisTransform;
    private Vector2 movementVector = Vector2.zero;
    public float jumpHeight = 1.5f;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
        thisTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
        KeepCharacterOnXAxis();
    }

    private void MoveCharacter()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal"), body.velocity.y);

        if (Input.GetButtonDown("Jump"))
           jumping();
        
    }

    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;

    }

    private void jumping()
    {
        body.velocity = new Vector2(body.velocity.x, jumpHeight);
        velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
    }

    
   
}

