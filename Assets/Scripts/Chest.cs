using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
                
        }
        
    }

}

