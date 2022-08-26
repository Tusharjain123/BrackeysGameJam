using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : Collidable
{
    
    protected override void OnCollide(Collider2D col)
    {
        if(col.name == "Player")
        {
            //TELEPORTING PLAYEr
            Debug.Log("PLAYER TELEPORTED TO ANOTHER STAGE");

        }
    }
}
