using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField]private int gateIndex = 0;
    Animator anim;
    bool gateOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        Button.buttonPressed += ButtonPressed;
        Button.buttonLeft += ButtonLeft;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ButtonPressed(int buttonIndex)
    {
        if(gateIndex == buttonIndex)
        {
            Debug.Log("GATE OPEN");
            gateOpen = !gateOpen;
            //Do Something about gate or trap movement
            //anim.SetTrigger("gate");
            anim.SetBool("Entry", gateOpen);
        }
    }
    private void ButtonLeft(int buttonIndex)
    {
        if (gateIndex == buttonIndex)
        {
            Debug.Log("DateClose");
            gateOpen = !gateOpen;
            //Do Something about gate or trap movement
            //anim.SetTrigger("gate");
            anim.SetBool("Entry", gateOpen);

        }
    }
}
