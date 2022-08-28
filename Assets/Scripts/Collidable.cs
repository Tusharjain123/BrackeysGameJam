using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxcollider;
    private Collider2D[] hits = new Collider2D[10];
    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        boxcollider.OverlapCollider(filter, hits);

        for(int i=0;i< hits.Length; i++)
        {
            if (hits[i] == null) continue;

            OnCollide(hits[i]);

           /* if(hits[i].tag == "KeyChest")
            {

            }*/

            Debug.Log(hits[i].name);

            hits[i] = null;
                                
        }
    }
    protected virtual void OnCollide(Collider2D col)
    {
        Debug.Log(col.name);
    }

    
}
