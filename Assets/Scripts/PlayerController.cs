using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 moveDir = Vector2.zero;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider2D;
    RaycastHit2D hit;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        MyInput();
        //Collision in y direction
        //hit = Physics2D.BoxCast(new Vector2(transform.position.x,transform.position.y), boxCollider2D.size, 0, new Vector2(0, moveDir.y), colCheckDistance,whatIsWall);
        hit = Physics2D.BoxCast(new Vector2(transform.position.x,transform.position.y), boxCollider2D.size, 0, new Vector2(0, moveDir.y), Mathf.Abs(moveDir.y * Time.deltaTime),LayerMask.GetMask("Entity","Blocking"));
        
        if(hit.collider == null)
        {
            transform.Translate(0, moveDir.y * Time.deltaTime, 0);

        }else
        {
            Debug.Log(hit.collider.name);
        }
        hit = Physics2D.BoxCast(new Vector2(transform.position.x, transform.position.y), boxCollider2D.size, 0, new Vector2(moveDir.x,0), Mathf.Abs(moveDir.x * Time.deltaTime),LayerMask.GetMask("Entity","Blocking"));
      
        if (hit.collider == null)
        {
            transform.Translate( moveDir.x * Time.deltaTime,0, 0);

        }
        else
        {
            Debug.Log(hit.collider.name);
        }
    }
    private void MyInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(x, y).normalized * speed;
    }
    
}
