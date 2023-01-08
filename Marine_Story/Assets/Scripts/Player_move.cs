using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // movement variables
    public float moveSpeed = 5f;
    public Transform originalParent;

    // reference to the character's Rigidbody2D component
    private Rigidbody2D rb;

    void Start()
    {
        // get reference to the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // get input from the horizontal and vertical axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // move the character
        transform.position += new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;
    }
}