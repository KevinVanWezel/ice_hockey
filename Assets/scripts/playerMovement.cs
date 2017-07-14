using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//playerMovement class moves and rotates the player 
public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // -1 is left, 0 is no direction, 1 is right
    public void Move(Vector3 direction)
    {
        Vector3 velocity = direction * speed * Time.deltaTime;
        transform.forward = direction;
        rb.MovePosition(rb.position + velocity);
    }
}

