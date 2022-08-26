using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector3(2, 3, 4), 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
