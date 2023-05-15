using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float x;
    public Rigidbody rb;
    public Vector3 movement;
    private Animator anim;
    
    void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        movement = new Vector3(0, 0, Input.GetAxis("Horizontal"));
    }

    void FixedUpdate()
    {
        moveCharacter(movement);

        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        } else
        {
            anim.SetBool("isMoving", false);
        }

        
    }

    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }

}
