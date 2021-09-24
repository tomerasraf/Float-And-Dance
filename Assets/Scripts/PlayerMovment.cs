using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private Vector2 movement;
    public float moveSpeed = 5f;
    public float spinSpeed = 5f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }

    void FixedUpdate()
    {
        MovePlayer(movement);
        RotatePlayer();
    }

    private void GetPlayerInput()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }

    private void MovePlayer(Vector2 movement)
    {
        rb2d.AddForce(movement * moveSpeed, ForceMode2D.Impulse);
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.J))
        {
            rb2d.AddTorque(spinSpeed);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rb2d.AddTorque(-spinSpeed);
        }
    }

}
