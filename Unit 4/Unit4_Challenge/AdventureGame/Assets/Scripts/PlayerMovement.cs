using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D body;
    public float moveSpeed = 5f;
    private Transform thisTransform;
    private Vector2 movementVector = Vector2.zero;
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

        if (Input.GetKey(KeyCode.Space))
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
        body.velocity = new Vector2(body.velocity.x, 5);
    }
}
