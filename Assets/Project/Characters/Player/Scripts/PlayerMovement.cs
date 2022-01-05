using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void MovePlayer(float speed)
    {
        rb.MovePosition(transform.position + transform.right * speed * Time.deltaTime);
    }

    public void Jump(float jumpForce)
    {
        rb.AddForce(transform.up * jumpForce);
    }
}