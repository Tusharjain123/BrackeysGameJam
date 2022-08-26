using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public int buttonIndex;
    public delegate void ButtonPressed(int buttonIndex);
    public static event ButtonPressed buttonPressed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            buttonPressed?.Invoke(buttonIndex); 
        }
    }
}
