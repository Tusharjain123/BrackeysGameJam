using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int moveSpeed;
    public float jumpForce;
    private float xinput;
    private Rigidbody2D rbd;
    [SerializeField] private GameObject groundCheck;
    public LayerMask layer;
    public bool isGrounded;
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xinput = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        isGrounded = Physics.CheckSphere(transform.position, 10f,layer);
    }

    private void FixedUpdate()
    {
        rbd.AddForce(new Vector2(xinput*moveSpeed,0));
    }

    void jump()
    {
        if(isGrounded)  
            rbd.AddForce(Vector2.up * jumpForce);
    }
}
