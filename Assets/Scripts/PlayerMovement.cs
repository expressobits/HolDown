using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] [Tooltip("Run Speed to player movement")]
    private float runSpeed;

    private Rigidbody2D rigidBody2D;

    private float horizontal;
    private float vertical;

    private void Awake() {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 
    }

    private void FixedUpdate() {
        rigidBody2D.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
