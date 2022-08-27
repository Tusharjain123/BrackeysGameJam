using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public int buttonIndex;
    public delegate void ButtonPressed(int buttonIndex);
    public static event ButtonPressed buttonPressed;
    public delegate void ButtonLeft(int buttonIndex);
    public static event ButtonLeft buttonLeft;
    //private Animator m_animator;
    void Start()
    {
        //m_animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("YES");
            buttonPressed?.Invoke(buttonIndex);
            //m_animator.SetBool("isPressed", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("YES");
            buttonLeft?.Invoke(buttonIndex);
            //m_animator.SetBool("isPressed", true);
        }
    }
}
